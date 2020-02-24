//-----------------------------------------------------------------------
// <copyright file="AbsShould.cs" company="PlaceholderCompany">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace QuickMaths.Test.Operations
{
    using QuickMaths;
    using Xunit;

    /// <summary>
    /// Unit tests for Abs operation.
    /// </summary>
    public class AbsShould
    {
        /// <summary>
        /// Check if Abs operation returns correct results.
        /// </summary>
        /// <param name="operand">An operand.</param>
        /// <param name="result">Expected result.</param>
        [Theory]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(-11, 11)]
        [InlineData(-123, 123)]
        [InlineData(2565983, 2565983)]
        public void ReturnCorrectResult(int operand, int result)
        {
            Assert.Equal(result, Operations.Abs(operand));
        }
    }
}