using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Infrastructure.ServiceBus.Azure;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class AzureServicebusInfrastructureExtensions
{
    public static IServiceCollection AddAzureServiceBus(this IServiceCollection services, IConfiguration config)
    {
        // Add Azure Service Bus
        services.AddSingleton<IServiceBusClient, AzureServiceBusClient>();

        // Setup registration
        services.Configure<AzureServiceBusSettings>(config.GetSection("AzureServiceBusSettings"));

        return services;
    }
}
