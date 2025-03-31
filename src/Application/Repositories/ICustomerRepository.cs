using payphone.challenge.restapi.Domain.Customers;

namespace payphone.challenge.restapi.Application.Repositories;

public interface ICustomerRepository
{
    Task<ICustomer> Get(Guid id);
    Task Add(ICustomer customer);
    Task Update(ICustomer customer);
}