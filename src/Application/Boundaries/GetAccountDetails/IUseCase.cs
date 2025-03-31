namespace payphone.challenge.restapi.Application.Boundaries.GetAccountDetails;

public interface IUseCase
{
    Task Execute(GetAccountDetailsInput getAccountDetailsInput);
}