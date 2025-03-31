namespace payphone.challenge.restapi.Application.Boundaries.Registers;
public interface IOutputPort : IErrorHandler
{
    void Standard(RegisterOutput registerOutput);
}