using payphone.challenge.restapi.Application.Boundaries.Registers;
using System.Collections.ObjectModel;

namespace payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory.Presenters;

public sealed class RegisterPresenter : IOutputPort
{
    public Collection<string> Errors { get; }
    public Collection<RegisterOutput> Registers { get; }

    public RegisterPresenter()
    {
        Errors = new Collection<string>();
        Registers = new Collection<RegisterOutput>();
    }

    public void Error(string message)
    {
        Errors.Add(message);
    }

    public void Standard(RegisterOutput output)
    {
        Registers.Add(output);
    }
}