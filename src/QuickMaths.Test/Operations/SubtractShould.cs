//-----------------------------------------------------------------------
// <copyright file="SubtractShould.cs" company="PlaceholderCompany">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace QuickMaths.Test.Operations
{
    using QuickMaths;
    using Xunit;

    /// <summary>
    /// Unit tests for Subtract operation.
    /// </summary>
    public class SubtractShould
    {
        /// <summary>
        /// Check if Subtract operation returns correct results.
        /// </summary>
        /// <param name="operand1">First operand.</param>
        /// <param name="operand2">Second operand.</param>
        /// <param name="result">Expected result.</param>
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