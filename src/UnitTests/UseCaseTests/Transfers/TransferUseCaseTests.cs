using payphone.challenge.restapi.Application.Boundaries.Transfers;
using payphone.challenge.restapi.Application.UseCases;
using payphone.challenge.restapi.Domain.ValueObjects;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory.Presenters;
using payphone.challenge.restapi.UnitTests.TestFixtures;
using Xunit;

namespace payphone.challenge.restapi.UnitTests.UseCaseTests.Transfers;

public sealed class TransferUseCaseTests : IClassFixture<StandardFixture>
{
    private readonly StandardFixture _fixture;
    public TransferUseCaseTests(StandardFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [ClassData(typeof(PositiveDataSetup))]
    public async Task Transfer_ChangesBalance_WhenAccountExists(
        decimal amount,
        decimal expectedOriginBalance)
    {
        var presenter = new TransferPresenter();
        var sut = new Transfer(
            _fixture.EntityFactory,
            presenter,
            _fixture.AccountRepository,
            _fixture.UnitOfWork,
            _fixture.ServiceBus
        );

        await sut.Execute(
            new TransferInput(
                _fixture.Context.DefaultAccountId,
                _fixture.Context.SecondAccountId,
                new PositiveMoney(amount)));

        var actual = presenter.Transfers.Last();
        Assert.Equal(expectedOriginBalance, actual.UpdatedBalance);
    }
}