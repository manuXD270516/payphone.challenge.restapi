namespace payphone.challenge.restapi.Application.Boundaries.Registers;

public interface IUseCase
{
    Task Execute(RegisterInput registerInput);
}