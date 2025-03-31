namespace payphone.challenge.restapi.Application.Boundaries.Transfers;


public interface IUseCase
{
    Task Execute(TransferInput transferInput);
}