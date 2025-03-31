using payphone.challenge.restapi.WebApi.Filters;

namespace payphone.challenge.restapi.WebApi.Extensions;

public static class BusinessExceptionExtensions
{
    public static IServiceCollection AddBusinessExceptionFilter(this IServiceCollection services)
    {
        services.AddMvc(options =>
        {
            options.Filters.Add(typeof(BusinessExceptionFilter));
        });

        return services;
    }
}
