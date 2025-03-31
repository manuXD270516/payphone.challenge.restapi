using payphone.challenge.restapi.Shared.Interfaces;

namespace payphone.challenge.restapi.Infrastructure.ServiceBus.Azure;

public interface IMessageEventHandler<in TIntegrationEvent> : IMessageEventHandler
    where TIntegrationEvent : IIntegrationEvent
{
    Task Handle(TIntegrationEvent @event);
}

public interface IMessageEventHandler
{

}
