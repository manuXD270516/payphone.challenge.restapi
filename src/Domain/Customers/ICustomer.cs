using payphone.challenge.restapi.Domain.Accounts;

namespace payphone.challenge.restapi.Domain.Customers;

public interface ICustomer : IAggregateRoot
{
    AccountCollection Accounts { get; }
    void Register(IAccount account);
}