using payphone.challenge.restapi.Infrastructure.ServiceBus.MassTransit;
using payphone.challenge.restapi.Worker.HostedServices;

namespace payphone.challenge.restapi.Worker.ConfigServices;

public class MassTransitServiceBusConfigurator
{
    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.Configure<MassTransitSetting>(context.Configuration.GetSection("MassTransitSetting"));
        services.AddHostedService<MassTransitBusService>();
    }
}
