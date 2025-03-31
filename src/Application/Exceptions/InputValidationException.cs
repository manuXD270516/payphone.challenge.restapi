using payphone.challenge.restapi.Domain;

namespace payphone.challenge.restapi.Application.Exceptions;

public sealed class InputValidationException : DomainException
{
    public InputValidationException(string message)
        : base(message)
    {

    }
}