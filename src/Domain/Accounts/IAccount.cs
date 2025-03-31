using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Domain.Accounts;

public interface IAccount : IAggregateRoot
{
    ICredit Deposit(IEntityFactory entityFactory, PositiveMoney amountToDeposit);
    IDebit? Withdraw(IEntityFactory entityFactory, PositiveMoney amountToWithdraw);
    bool IsClosingAllowed();
    Money GetCurrentBalance();
}