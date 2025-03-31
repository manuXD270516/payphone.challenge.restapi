using payphone.challenge.restapi.Infrastructure.ServiceBus.Azure;
using payphone.challenge.restapi.Worker.HostedServices;

namespace payphone.challenge.restapi.Worker.ConfigServices;


public class AzureServiceBusConfigurator
{
    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.Configure<AzureServiceBusSettings>(context.Configuration.GetSection("AzureServiceBusSettings"));
        services.AddHostedService<AzureBusHostService>();
    }
}
