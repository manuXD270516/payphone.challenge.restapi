using payphone.challenge.restapi.Application.Exceptions;

namespace payphone.challenge.restapi.Application.Boundaries.CloseAccount;

public sealed class CloseAccountInput
{
    public Guid AccountId { get; }

    public CloseAccountInput(Guid accountId)
    {
        if (accountId == Guid.Empty)
        {
            throw new InputValidationException($"{nameof(accountId)} cannot be empty.");
        }

        AccountId = accountId;
    }
}