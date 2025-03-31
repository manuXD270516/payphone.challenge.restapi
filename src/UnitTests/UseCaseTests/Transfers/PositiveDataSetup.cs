namespace payphone.challenge.restapi.UnitTests.UseCaseTests.Transfers
{
    using Xunit;

    internal sealed class PositiveDataSetup : TheoryData<decimal, decimal>
    {
        public PositiveDataSetup()
        {
            Add(100, 600);
        }
    }
}