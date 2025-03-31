using payphone.challenge.restapi.Shared.ReadModels;

namespace payphone.challenge.restapi.Application.Services;

public interface IDummyApiClient : IApiClient
{
    Task<SimpleResult> GetSimpleModelAsync(string id);
}
