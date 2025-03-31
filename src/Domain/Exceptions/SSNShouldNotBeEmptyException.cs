namespace payphone.challenge.restapi.Domain.Exceptions;

public sealed class SSNShouldNotBeEmptyException : DomainException
{
    internal SSNShouldNotBeEmptyException(string message)
        : base(message)
    {
    }
}