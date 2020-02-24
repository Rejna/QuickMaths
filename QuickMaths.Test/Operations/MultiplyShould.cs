namespace QuickMaths.Test.Operations
{
    using QuickMaths;
    using Xunit;

    public class MultiplyShould
    {
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 1, 2)]
        [InlineData(1, 0, 0)]
        [InlineData(1, -1, -1)]
        [InlineData(123, -123, -15129)]
        [InlineData(2565, 5840, 14979600)]
        public void ReturnCorrectResult(int operand1, int operand2, int result)
        {
            Assert.Equal(result, Operations.Multiply(operand1, operand2));
        }
    }
}