using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Shared.Interfaces;

namespace payphone.challenge.restapi.UnitTests.TestFixtures;

public class FakeServiceBus : IServiceBusClient
{
    public async Task PublishEventAsync<T>(T evt) where T : IEvent
    {
        await Task.CompletedTask;
    }

    public async Task SendCommandAsync<T>(T cmd) where T : ICommand
    {
        await Task.CompletedTask;
    }
}
