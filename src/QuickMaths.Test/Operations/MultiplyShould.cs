//-----------------------------------------------------------------------
// <copyright file="MultiplyShould.cs" company="PlaceholderCompany">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace QuickMaths.Test.Operations
{
    using QuickMaths;
    using Xunit;

    /// <summary>
    /// Unit tests for Multiply operation.
    /// </summary>
    public class MultiplyShould
    {
        /// <summary>
        /// Check Multiply operation if returns correct results.
        /// </summary>
        /// <param name="operand1">First operand.</param>
        /// <param name="operand2">Second operand.</param>
        /// <param name="result">Expected result.</param>
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