using payphone.challenge.restapi.Application.Boundaries.Withdraws;
using payphone.challenge.restapi.Application.UseCases;
using payphone.challenge.restapi.Domain.ValueObjects;
using payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory.Presenters;
using payphone.challenge.restapi.UnitTests.TestFixtures;
using Xunit;

namespace payphone.challenge.restapi.UnitTests.UseCaseTests.Withdraws;

public sealed class WithdrawlTests : IClassFixture<StandardFixture>
{
    private readonly StandardFixture _fixture;
    public WithdrawlTests(StandardFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [ClassData(typeof(PositiveDataSetup))]
    public async Task Withdraw_Valid_Amount(
        decimal amount,
        decimal expectedBalance)
    {
        var presenter = new WithdrawPresenter();
        var sut = new Withdraw(
            _fixture.EntityFactory,
            presenter,
            _fixture.AccountRepository,
            _fixture.UnitOfWork,
            _fixture.ServiceBus
        );

        await sut.Execute(new WithdrawInput(
            _fixture.Context.DefaultAccountId,
            new PositiveMoney(amount)));

        var actual = presenter.Withdrawals.Last();
        Assert.Equal(expectedBalance, actual.UpdatedBalance);
    }
}