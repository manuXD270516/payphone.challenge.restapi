using payphone.challenge.restapi.Shared.ReadModels;

namespace payphone.challenge.restapi.Application.Services;

public interface IAuthApiClient : IApiClient
{
    Task<SimpleResult> GetSimpleAuthModelAsync(string id);
}
