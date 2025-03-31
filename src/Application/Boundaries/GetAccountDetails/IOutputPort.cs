namespace payphone.challenge.restapi.Application.Boundaries.GetAccountDetails;

public interface IOutputPort : IErrorHandler
{
    void Default(GetAccountDetailsOutput getAccountDetailsOutput);
    void NotFound(string message);
}