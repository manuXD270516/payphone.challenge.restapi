using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Infrastructure.ServiceBus.Particular;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class ParticularServicebusInfrastructureExtensions
{
    public static IServiceCollection AddParticularServiceBus(this IServiceCollection services, IConfiguration config)
    {
        // Add Particular NService Bus 
        services.AddSingleton<IServiceBusClient, ParticularServiceBusClient>();

        // Setup registration
        services.Configure<ParticularServiceBusSettings>(config.GetSection("ParticularServiceBusSettings"));

        return services;
    }
}
