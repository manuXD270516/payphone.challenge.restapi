using payphone.challenge.restapi.Shared.Interfaces;

namespace payphone.challenge.restapi.Shared.Events;

public class DemoEventOccurred : IIntegrationEvent
{
    public string? Payload { get; set; }
    public int Value { get; set; }
}
