using payphone.challenge.restapi.Domain.Accounts;

namespace payphone.challenge.restapi.Application.Boundaries.CloseAccount;

public sealed class CloseAccountOutput
{
    public Guid AccountId { get; }

    public CloseAccountOutput(IAccount account)
    {
        AccountId = account.Id;
    }
}