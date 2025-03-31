using payphone.challenge.restapi.Domain;
using payphone.challenge.restapi.Domain.Accounts;
using payphone.challenge.restapi.Domain.Customers;
using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory;

public sealed class EntityFactory : IEntityFactory
{
    public IAccount NewAccount(ICustomer customer)
        => new Account(customer);

    public ICredit NewCredit(IAccount account, PositiveMoney amountToDeposit, DateTime transactionDate)
        => new Credit(account, amountToDeposit, transactionDate);

    public ICustomer NewCustomer(SSN ssn, Name name)
        => new Customer(ssn, name);

    public IDebit NewDebit(IAccount account, PositiveMoney amountToWithdraw, DateTime transactionDate)
        => new Debit(account, amountToWithdraw, transactionDate);
}