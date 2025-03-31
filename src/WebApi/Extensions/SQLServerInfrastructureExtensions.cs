using payphone.challenge.restapi.Application.Repositories;
using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Domain;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.EntityFramework;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class SQLServerInfrastructureExtensions
{
    public static IServiceCollection AddSQLServerPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IEntityFactory, EntityFactory>();

        services.AddDbContext<GenocsContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}
