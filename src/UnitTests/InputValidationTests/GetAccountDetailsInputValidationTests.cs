using payphone.challenge.restapi.Application.Boundaries.GetAccountDetails;
using payphone.challenge.restapi.Application.Exceptions;
using Xunit;

namespace payphone.challenge.restapi.UnitTests.InputValidationTests;

public sealed class GetAccountDetailsInputValidationTests
{
    [Fact]
    public void GivenEmptyAccountId_InputNotCreated_ThrowsInputValidationException()
    {
        var actualEx = Assert.Throws<InputValidationException>(
            () => new GetAccountDetailsInput(
                Guid.Empty
            ));
        Assert.Contains("accountId", actualEx.Message);
    }

    [Fact]
    public void GivenValidData_InputCreated()
    {
        var actual = new GetAccountDetailsInput(
            Guid.NewGuid()
        );
        Assert.NotNull(actual);
    }
}