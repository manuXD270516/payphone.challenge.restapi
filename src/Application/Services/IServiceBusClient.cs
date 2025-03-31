using payphone.challenge.restapi.Shared.Interfaces;

namespace payphone.challenge.restapi.Application.Services;

public interface IServiceBusClient
{
    Task SendCommandAsync<T>(T cmd)
        where T : ICommand;

    Task PublishEventAsync<T>(T evt)
        where T : IEvent;
}