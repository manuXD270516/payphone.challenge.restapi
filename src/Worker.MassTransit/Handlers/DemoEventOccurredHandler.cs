using payphone.challenge.restapi.Shared.Events;
using MassTransit;

namespace payphone.challenge.restapi.Worker.MassTransit.Handlers;

public class DemoEventOccurredHandler : IConsumer<DemoEventOccurred>
{
    private readonly ILogger<DemoEventOccurredHandler> _logger;

    public DemoEventOccurredHandler(ILogger<DemoEventOccurredHandler> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<DemoEventOccurred> context)
    {
        _logger.LogInformation(context.Message.Payload);
        return Task.CompletedTask;
    }
}
