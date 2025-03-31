namespace payphone.challenge.restapi.Domain.Exceptions;

public sealed class MoneyShouldBePositiveException : DomainException
{
    internal MoneyShouldBePositiveException(string message)
        : base(message)
    {
    }
}