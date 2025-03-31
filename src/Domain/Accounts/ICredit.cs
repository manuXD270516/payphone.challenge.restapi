using payphone.challenge.restapi.Domain.ValueObjects;

namespace payphone.challenge.restapi.Domain.Accounts;

public interface ICredit : IEntity
{
    PositiveMoney Sum(PositiveMoney amount);
}