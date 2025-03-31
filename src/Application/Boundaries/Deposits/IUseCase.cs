namespace payphone.challenge.restapi.Application.Boundaries.Deposits;

public interface IUseCase
{
    Task Execute(DepositInput depositInput);
}