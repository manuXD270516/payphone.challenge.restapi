using payphone.challenge.restapi.Domain.Accounts;
using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Application.Boundaries.Refunds;

public sealed class RefundOutput
{
    public Transaction Transaction { get; }
    public decimal UpdatedBalance { get; }

    public RefundOutput(IDebit debit, Money updatedBalance)
    {
        Debit debitEntity = (Debit)debit;

        Transaction = new Transaction(
            debitEntity.Description,
            debitEntity.Amount
            .ToMoney()
            .ToDecimal(),
            debitEntity.TransactionDate);

        UpdatedBalance = updatedBalance.ToDecimal();
    }
}