namespace QuickMaths.Test.Operations
{
    using QuickMaths;
    using Xunit;

    public class AddShould
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 1, 3)]
        [InlineData(1, 0, 1)]
        [InlineData(1, -1, 0)]
        [InlineData(123, -123, 0)]
        [InlineData(2565983, 58409345, 60975328)]
        public void ReturnCorrectResult(int operand1, int operand2, int result)
        {
            Assert.Equal(result, Operations.Add(operand1, operand2));
        }
    }
}