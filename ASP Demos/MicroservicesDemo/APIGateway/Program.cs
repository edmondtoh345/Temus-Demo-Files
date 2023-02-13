using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using System.Text;

namespace APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("ocelot.json").Build();
            builder.Services.AddOcelot(config).AddConsul();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this_is_my_secret_key_for_user"));
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,

                ValidateIssuer = true,
                ValidIssuer = "authapi",

                ValidateAudience = true,
                ValidAudience = "customerapi"
            });
            var app = builder.Build();

            app.UseOcelot();
            app.UseAuthentication();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}