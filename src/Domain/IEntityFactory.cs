using payphone.challenge.restapi.Domain.Accounts;
using payphone.challenge.restapi.Domain.Customers;
using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Domain;

public interface IEntityFactory
{
    ICustomer NewCustomer(SSN ssn, Name name);
    IAccount NewAccount(ICustomer customer);
    ICredit NewCredit(IAccount account, PositiveMoney amountToDeposit, DateTime transactionDate);
    IDebit NewDebit(IAccount account, PositiveMoney amountToWithdraw, DateTime transactionDate);
}