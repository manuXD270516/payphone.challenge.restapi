using payphone.challenge.restapi.Shared.Particular.IntegrationEvents;
using payphone.challenge.restapi.Shared.Particular.TransactionSaga;
using NServiceBus;
using NServiceBus.Logging;

namespace payphone.challenge.restapi.Worker.Handlers;

/// <summary>
/// Basic event handler.
/// This event handler will be registered automatically. It do not need any action to be up and running.
/// </summary>
public class BasicEventHandler : IHandleMessages<BasicEvent>
{
    private static readonly ILog _log = LogManager.GetLogger<BasicEventHandler>();

    public async Task Handle(BasicEvent message, IMessageHandlerContext context)
    {
        _log.Info($"WorkerService.BasicEventHandler has received a message");


        await context.SendLocal(new TransactionLoaded()
        {
            RequestId = Guid.NewGuid().ToString(),
            TransactionId = Guid.NewGuid().ToString()
        });
    }
}
