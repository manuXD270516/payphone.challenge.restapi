namespace payphone.challenge.restapi.Application.Boundaries.CloseAccount;

public interface IUseCase
{
    Task Execute(CloseAccountInput closeAccountInput);
}