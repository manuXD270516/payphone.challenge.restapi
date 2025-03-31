using payphone.challenge.restapi.Application.Boundaries.Registers;
using payphone.challenge.restapi.Application.UseCases;
using payphone.challenge.restapi.Domain.ValueObjects;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory.Presenters;
using payphone.challenge.restapi.UnitTests.TestFixtures;
using Xunit;

namespace payphone.challenge.restapi.UnitTests.UseCaseTests.Registers;

public sealed class RegisterTests : IClassFixture<StandardFixture>
{
    private readonly StandardFixture _fixture;
    public RegisterTests(StandardFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task GivenNullInputThrowsExceptionAsync()
    {
        var register = new Register(null, null, null, null, null, null);
        await Assert.ThrowsAsync<NullReferenceException>(async () => await register.Execute(null));
    }

    [Theory]
    [ClassData(typeof(PositiveDataSetup))]
    public async Task RegisterWritesOutputInputIsValidAsync(decimal amount)
    {
        var presenter = new RegisterPresenter();
        var ssn = new SSN("8608178888");
        var name = new Name("Nocco Giovanni Emanuele");

        var sut = new Register(
            _fixture.EntityFactory,
            presenter,
            _fixture.CustomerRepository,
            _fixture.AccountRepository,
            _fixture.UnitOfWork,
            _fixture.ServiceBus);

        await sut.Execute(new RegisterInput(
            ssn,
            name,
            new PositiveMoney(amount)));

        var actual = presenter.Registers.Last();
        Assert.NotNull(actual);
        Assert.Equal(ssn.ToString(), actual.Customer.SSN);
        Assert.Equal(name.ToString(), actual.Customer.Name);
        Assert.Equal(amount, actual.Account.CurrentBalance);
    }
}