namespace payphone.challenge.restapi.Application.Boundaries.CloseAccount;

public interface IOutputPort : IErrorHandler
{
    void Default(CloseAccountOutput closeAccountOutput);
}