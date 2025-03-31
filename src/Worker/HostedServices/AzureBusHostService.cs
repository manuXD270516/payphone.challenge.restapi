using payphone.challenge.restapi.Infrastructure.ServiceBus.Azure;
using payphone.challenge.restapi.Shared.Events;
using Microsoft.Extensions.Options;

namespace payphone.challenge.restapi.Worker.HostedServices;

internal class AzureBusHostService : AzureBusService
{
    public AzureBusHostService(
                                IOptions<AzureServiceBusSettings> options,
                                ILogger<AzureBusService> logger,
                                IServiceProvider serviceProvider)
        : base(options, logger, serviceProvider)
    {
        RegisterMessage<IntegrationEventIssued, IMessageEventHandler<IntegrationEventIssued>>();
    }
}
