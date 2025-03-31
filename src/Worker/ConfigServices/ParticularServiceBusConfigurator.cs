using payphone.challenge.restapi.Infrastructure.ServiceBus.Particular;
using payphone.challenge.restapi.Worker.HostedServices;

namespace payphone.challenge.restapi.Worker.ConfigServices;

public class ParticularServiceBusConfigurator
{
    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.Configure<ParticularServiceBusSettings>(context.Configuration.GetSection("ParticularServiceBusSettings"));
        services.AddHostedService<ParticularService>();
    }
}
