using payphone.challenge.restapi.Domain.Accounts;
using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Infrastructure.PersistenceLayer.EntityFramework;

public class Credit : Domain.Accounts.Credit
{
    public Guid AccountId { get; protected set; }

    protected Credit() { }

    public Credit(IAccount account, PositiveMoney amountToDeposit, DateTime transactionDate)
    {
        AccountId = account.Id;
        this.Amount = amountToDeposit;
        this.TransactionDate = transactionDate;
    }
}