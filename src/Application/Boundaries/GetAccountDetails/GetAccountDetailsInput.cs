using payphone.challenge.restapi.Application.Exceptions;

namespace payphone.challenge.restapi.Application.Boundaries.GetAccountDetails;

public sealed class GetAccountDetailsInput
{
    public Guid AccountId { get; }

    public GetAccountDetailsInput(Guid accountId)
    {
        if (accountId == Guid.Empty)
        {
            throw new InputValidationException($"{nameof(accountId)} cannot be empty.");
        }

        AccountId = accountId;
    }
}