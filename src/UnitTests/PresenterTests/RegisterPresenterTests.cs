using payphone.challenge.restapi.Application.Boundaries.Registers;
using payphone.challenge.restapi.Domain.ValueObjects;
using payphone.challenge.restapi.WebApi.UseCases.V1.Register;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Xunit;

namespace payphone.challenge.restapi.UnitTests.PresenterTests;


public sealed class RegisterPresenterTests
{
    [Fact]
    public void GivenValidData_Handle_WritesOkObjectResult()
    {
        var customer = new Infrastructure.PersistenceLayer.InMemory.Customer(
            new SSN("198608178888"),
            new Name("Nocco Giovanni Emanuele")
        );

        var account = new Infrastructure.PersistenceLayer.InMemory.Account(
            customer
        );

        var registerOutput = new RegisterOutput(
            customer,
            account
        );

        var sut = new RegisterPresenter();
        sut.Standard(registerOutput);

        var actual = Assert.IsType<CreatedAtRouteResult>(sut.ViewModel);
        Assert.Equal((int)HttpStatusCode.Created, actual.StatusCode);

        var actualValue = (RegisterResponse)actual.Value;
        Assert.Equal(customer.Id, actualValue.CustomerId);
    }
}