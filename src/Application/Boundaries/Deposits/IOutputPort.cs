namespace payphone.challenge.restapi.Application.Boundaries.Deposits;

public interface IOutputPort : IErrorHandler
{
    void Default(DepositOutput depositOutput);
}