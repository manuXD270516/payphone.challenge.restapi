namespace payphone.challenge.restapi.Application.Boundaries.GetCustomerDetails;

public interface IUseCase
{
    Task Execute(GetCustomerDetailsInput getCustomerDetailsInput);
}