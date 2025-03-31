using payphone.challenge.restapi.Application.Repositories;
using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Domain;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory.Repositories;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class InMemoryInfrastructureExtensions
{
    public static IServiceCollection AddInMemoryPersistence(this IServiceCollection services)
    {
        services.AddScoped<IEntityFactory, EntityFactory>();

        services.AddSingleton<GenocsContext, GenocsContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}
