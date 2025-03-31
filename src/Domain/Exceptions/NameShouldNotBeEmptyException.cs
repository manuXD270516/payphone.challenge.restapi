namespace payphone.challenge.restapi.Domain.Exceptions;

public sealed class NameShouldNotBeEmptyException : DomainException
{
    internal NameShouldNotBeEmptyException(string message)
        : base(message)
    {
    }
}