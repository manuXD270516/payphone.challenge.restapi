using payphone.challenge.restapi.Domain.Customers;
using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Infrastructure.PersistenceLayer.InMemory;

public class Customer : Domain.Customers.Customer
{
    public Customer()
    {
    }

    public Customer(SSN ssn, Name name)
    {
        Id = Guid.NewGuid();
        SSN = ssn;
        Name = name;
    }

    public void LoadAccounts(IEnumerable<Guid> accounts)
    {
        Accounts = new AccountCollection();
        Accounts.Add(accounts);
    }
}