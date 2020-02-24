namespace QuickMaths.Test.Operations
{
    using QuickMaths;
    using Xunit;

    public class SubtractShould
    {
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, -1, 2)]
        [InlineData(123, -123, 246)]
        [InlineData(2565983, 58409345, -55843362)]
        public void ReturnCorrectResult(int operand1, int operand2, int result)
        {
            Assert.Equal(result, Operations.Subtract(operand1, operand2));
        }
    }
}