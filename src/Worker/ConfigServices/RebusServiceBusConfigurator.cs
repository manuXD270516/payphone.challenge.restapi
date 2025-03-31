using payphone.challenge.restapi.Infrastructure.ServiceBus.Rebus;
using payphone.challenge.restapi.Worker.HostedServices;

namespace payphone.challenge.restapi.Worker.ConfigServices;

public class RebusServiceBusConfigurator
{
    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.Configure<RebusBusSettings>(context.Configuration.GetSection("RebusBusSettings"));
        services.AddHostedService<RebusService>();
    }
}
