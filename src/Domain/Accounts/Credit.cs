using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Domain.Accounts;

public class Credit : ICredit
{
    public Guid Id { get; protected set; }
    public PositiveMoney Amount { get; protected set; } = new PositiveMoney(0);
    public string Description
    {
        get { return "Credit"; }
    }

    public DateTime TransactionDate { get; protected set; }

    public PositiveMoney Sum(PositiveMoney amount)
    {
        return Amount.Add(amount);
    }
}