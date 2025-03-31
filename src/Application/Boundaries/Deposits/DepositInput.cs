using payphone.challenge.restapi.Application.Exceptions;
using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Application.Boundaries.Deposits;

public sealed class DepositInput
{
    public Guid AccountId { get; }
    public PositiveMoney Amount { get; }

    public DepositInput(Guid accountId, PositiveMoney amount)
    {
        if (accountId == Guid.Empty)
        {
            throw new InputValidationException($"{nameof(accountId)} cannot be empty.");
        }

        if (amount == null)
        {
            throw new InputValidationException($"{nameof(amount)} cannot be null.");
        }

        AccountId = accountId;
        Amount = amount;
    }
}