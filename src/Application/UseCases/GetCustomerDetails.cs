using payphone.challenge.restapi.Application.Boundaries.GetCustomerDetails;
using payphone.challenge.restapi.Application.Repositories;

namespace payphone.challenge.restapi.Application.UseCases;

public sealed class GetCustomerDetails : IUseCase
{
    private readonly IOutputPort _outputHandler;
    private readonly ICustomerRepository _customerRepository;
    private readonly IAccountRepository _accountRepository;

    public GetCustomerDetails(
                              IOutputPort outputHandler,
                              ICustomerRepository customerRepository,
                              IAccountRepository accountRepository)
    {
        _outputHandler = outputHandler;
        _customerRepository = customerRepository;
        _accountRepository = accountRepository;
    }

    public async Task Execute(GetCustomerDetailsInput input)
    {
        var customer = await _customerRepository.Get(input.CustomerId);

        if (customer == null)
        {
            _outputHandler.NotFound($"The customer {input.CustomerId} does not exist or is not processed yet.");
            return;
        }

        List<Account> accounts = new List<Account>();

        foreach (var accountId in customer.Accounts.GetAccountIds())
        {
            var account = await _accountRepository.Get(accountId);

            if (account != null)
            {
                Account accountOutput = new Account(account);
                accounts.Add(accountOutput);
            }
        }

        GetCustomerDetailsOutput output = new GetCustomerDetailsOutput(customer, accounts);
        _outputHandler.Default(output);
    }
}