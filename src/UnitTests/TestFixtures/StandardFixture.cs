using payphone.challenge.restapi.Application.Services;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory.Repositories;

namespace payphone.challenge.restapi.UnitTests.TestFixtures;

public sealed class StandardFixture
{
    public EntityFactory EntityFactory { get; }
    public GenocsContext Context { get; }
    public AccountRepository AccountRepository { get; }
    public CustomerRepository CustomerRepository { get; }
    public UnitOfWork UnitOfWork { get; }

    public IServiceBusClient ServiceBus { get; }

    public StandardFixture()
    {
        Context = new GenocsContext();
        AccountRepository = new AccountRepository(Context);
        CustomerRepository = new CustomerRepository(Context);
        UnitOfWork = new UnitOfWork(Context);
        EntityFactory = new EntityFactory();
        ServiceBus = new FakeServiceBus();
    }
}