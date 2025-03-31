namespace payphone.challenge.restapi.Shared.Events;

public class CloseAccountCompleted : Interfaces.IEvent
{
    public Guid AccountId { get; set; }
}
