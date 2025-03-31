namespace payphone.challenge.restapi.Application.Boundaries.Withdraws;

public interface IOutputPort : IErrorHandler
{
    void Default(WithdrawOutput withdrawOutput);
}