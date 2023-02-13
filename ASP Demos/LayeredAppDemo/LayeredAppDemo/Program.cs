using Consul;
using LayeredAppDemo.Middlewares;
using LayeredAppDemo.Models;
using LayeredAppDemo.Repository;
using LayeredAppDemo.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Values;
using System.Text;

namespace LayeredAppDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var con = Environment.GetEnvironmentVariable("SQL_DB");
            
            if (con == null)
            {
                builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));
            }
            else
            {
                builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(con));
            }
            
            builder.Services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                consulConfig.Address = new System.Uri(builder.Configuration["ConsulConfig:ConsulAddress"]);
            }));

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            // Add services to the container.
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this_is_my_secret_key_for_user"));
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters(){
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,

                ValidateIssuer = true,
                ValidIssuer= "authapi",

                ValidateAudience =true,
                ValidAudience = "customerapi"
            });
            builder.Services.AddCors(options => options.AddPolicy("MyCorsPolicy", policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseConsul(builder.Configuration);
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("MyCorsPolicy");
            app.UseHandleExceptionMiddleware();
            app.UseAuthentication().UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}