using payphone.challenge.restapi.Shared.Interfaces;

namespace payphone.challenge.restapi.Shared.Commands;

public class SimpleMessage : ICommand
{
    public string? MessageId { get; set; }

    public string? MessageBody { get; set; }

}
