namespace payphone.challenge.restapi.Domain;

public class DomainException : Exception
{
    public DomainException(string businessMessage) : base(businessMessage) { }
}