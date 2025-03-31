using payphone.challenge.restapi.Application.Boundaries.Withdraws;
using payphone.challenge.restapi.Application.Exceptions;
using payphone.challenge.restapi.Domain.ValueObjects;
using Xunit;

namespace payphone.challenge.restapi.UnitTests.InputValidationTests;

public sealed class WithdrawInputValidationTests
{
    [Fact]
    public void GivenEmptyAccountId_InputNotCreated_ThrowsInputValidationException()
    {
        var actualEx = Assert.Throws<InputValidationException>(
            () => new WithdrawInput(
                Guid.Empty,
                new PositiveMoney(10)
            ));
        Assert.Contains("accountId", actualEx.Message);
    }

    [Fact]
    public void GivenNullAmount_InputNotCreated_ThrowsInputValidationException()
    {
        var actualEx = Assert.Throws<InputValidationException>(
            () => new WithdrawInput(
                Guid.NewGuid(),
                null
            ));
        Assert.Contains("amount", actualEx.Message);
    }

    [Fact]
    public void GivenValidData_InputCreated()
    {
        var actual = new WithdrawInput(
            Guid.NewGuid(),
            new PositiveMoney(10)
        );
        Assert.NotNull(actual);
    }
}