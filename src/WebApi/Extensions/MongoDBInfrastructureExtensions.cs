using payphone.challenge.restapi.Application.Repositories;
using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Domain;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.MongoDb;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.MongoDb.Repositories;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class MongoDBInfrastructureExtensions
{
    public static IServiceCollection AddMongoDBPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        // Initialize the static conventions
        GenocsContext.RegisterConventions();

        services.AddScoped<IEntityFactory, EntityFactory>();
        services.AddScoped<IMongoContext, GenocsContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}
