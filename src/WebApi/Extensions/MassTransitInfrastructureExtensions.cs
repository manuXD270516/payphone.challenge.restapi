using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Infrastructure.ServiceBus.MassTransit;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class MassTransitInfrastructureExtensions
{
    public static IServiceCollection AddMassTransitServiceBus(this IServiceCollection services, IConfiguration config)
    {
        // Add Mass Transit Azure Service Bus 
        services.AddSingleton<IServiceBusClient, MassTransitServiceBusClient>();

        // Settings registration
        services.Configure<MassTransitSetting>(config.GetSection(MassTransitSetting.Position));

        return services;
    }
}
