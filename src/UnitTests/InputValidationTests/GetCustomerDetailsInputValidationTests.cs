using payphone.challenge.restapi.Application.Boundaries.GetCustomerDetails;
using payphone.challenge.restapi.Application.Exceptions;
using Xunit;

namespace payphone.challenge.restapi.UnitTests.InputValidationTests;


public sealed class GetCustomerDetailsInputValidationTests
{
    [Fact]
    public void GivenEmptyAccountId_InputNotCreated_ThrowsInputValidationException()
    {
        var actualEx = Assert.Throws<InputValidationException>(
            () => new GetCustomerDetailsInput(
                Guid.Empty
            ));
        Assert.Contains("customerId", actualEx.Message);
    }

    [Fact]
    public void GivenValidData_InputCreated()
    {
        var actual = new GetCustomerDetailsInput(
            Guid.NewGuid()
        );
        Assert.NotNull(actual);
    }
}