namespace payphone.challenge.restapi.Application.Boundaries.Withdraws;

public interface IUseCase
{
    Task Execute(WithdrawInput withdrawInput);
}