namespace payphone.challenge.restapi.Application.Boundaries.Refunds;

public interface IUseCase
{
    Task Execute(RefundInput refundInput);
}