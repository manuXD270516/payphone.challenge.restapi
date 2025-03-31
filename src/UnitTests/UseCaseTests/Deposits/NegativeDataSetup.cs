namespace payphone.challenge.restapi.UnitTests.UseCaseTests.Deposits
{
    using Xunit;

    internal sealed class NegativeDataSetup : TheoryData<decimal>
    {
        public NegativeDataSetup()
        {
            Add(-100);
        }
    }
}