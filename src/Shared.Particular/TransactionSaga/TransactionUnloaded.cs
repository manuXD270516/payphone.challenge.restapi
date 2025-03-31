using NServiceBus;

namespace payphone.challenge.restapi.Shared.Particular.TransactionSaga;

/// <summary>
/// This event happen whenever the system receive an Unload.
/// </summary>
public class TransactionUnloaded : IEvent
{
    public string? RequestId { get; set; }
    public string? TransactionId { get; set; }
}
