using payphone.challenge.restapi.Infrastructure.ServiceBus.Azure;
using payphone.challenge.restapi.Shared.Events;

namespace payphone.challenge.restapi.Worker.Handlers;

public class MassTransitEventOccurredHandler : IMessageEventHandler<IntegrationEventIssued>
{
    private readonly ILogger<MassTransitEventOccurredHandler> _logger;

    public MassTransitEventOccurredHandler(ILogger<MassTransitEventOccurredHandler> logger)
        => _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    public Task Handle(IntegrationEventIssued @event)
    {
        _logger.LogDebug("Processed message");

        // Do something with the message here
        return Task.CompletedTask;
    }
}
