namespace payphone.challenge.restapi.Application.Boundaries.Transfers;

public interface IOutputPort : IErrorHandler
{
    void Default(TransferOutput transferOutput);
}