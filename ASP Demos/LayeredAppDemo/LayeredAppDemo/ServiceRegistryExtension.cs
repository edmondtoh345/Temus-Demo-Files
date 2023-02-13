using Consul;

namespace LayeredAppDemo
{
    public static class ServiceRegistryExtension
    {
        // Creating middleware for registering service on Consul
        // Name of the middle ware is UseConsul
        public static IApplicationBuilder UseConsul(this IApplicationBuilder app, IConfiguration configurationSetting)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger("AppExtension");
            var lifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();

            // This is registration configuration that I am reading from appsettings.json file
            var registration = new AgentServiceRegistration()
            {
                ID = configurationSetting["ConsulConfig:ServiceName"],
                Name = configurationSetting["ConsulConfig:ServiceName"],
                Address = configurationSetting["ConsulConfig:ServiceHost"],
                Port = int.Parse(configurationSetting["ConsulConfig:ServicePort"])
            };

            logger.LogInformation("Registering with consul");
            //Here I am registering the service with service ID
            consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
            consulClient.Agent.ServiceRegister(registration).ConfigureAwait(true);

            lifetime.ApplicationStopped.Register(() =>
            {
                logger.LogInformation("Unregistering service from consul");
                consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(!true);
            });
            return app;
        }


    }
}
