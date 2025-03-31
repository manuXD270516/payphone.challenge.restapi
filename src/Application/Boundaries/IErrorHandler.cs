namespace payphone.challenge.restapi.Application.Boundaries;

public interface IErrorHandler
{
    void Error(string message);
}