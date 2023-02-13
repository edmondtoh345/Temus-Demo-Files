using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;

namespace APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("ocelot.json").Build();

            builder.Services.AddOcelot(config).AddConsul();
            var app = builder.Build();
            app.UseOcelot().Wait();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}