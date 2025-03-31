namespace payphone.challenge.restapi.Application.Services;

public interface IUnitOfWork
{
    Task<int> Save();
}