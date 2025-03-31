using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Infrastructure.ServiceBus.Rebus;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class RebusServicebusInfrastructureExtensions
{
    public static IServiceCollection AddRebusServiceBus(this IServiceCollection services, IConfiguration config)
    {
        // Add Rebus Service Bus 
        services.AddSingleton<IServiceBusClient, RebusServiceBusClient>();

        // Setup registration
        services.Configure<RebusBusSettings>(config.GetSection("RebusBusSettings"));

        return services;
    }
}
