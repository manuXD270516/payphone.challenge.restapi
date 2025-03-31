using payphone.challenge.restapi.Shared.Interfaces;

namespace payphone.challenge.restapi.Shared.Events;

public class IntegrationEventIssued : IIntegrationEvent
{
    public string? Title { get; set; }
}
