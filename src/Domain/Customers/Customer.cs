using payphone.challenge.restapi.Domain.Accounts;
using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Domain.Customers;

public class Customer : ICustomer
{
    public Guid Id { get; protected set; }
    public Name? Name { get; protected set; }
    public SSN? SSN { get; protected set; }
    public AccountCollection Accounts { get; protected set; }

    public Customer()
    {
        Accounts = new AccountCollection();
    }

    public void Register(IAccount account)
    {
        if (Accounts == null)
            Accounts = new AccountCollection();

        Accounts.Add(account.Id);
    }
}