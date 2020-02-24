//-----------------------------------------------------------------------
// <copyright file="SquareShould.cs" company="PlaceholderCompany">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace QuickMaths.Test.Operations
{
    using QuickMaths;
    using Xunit;

    /// <summary>
    /// Unit tests for Square operation.
    /// </summary>
    public class SquareShould
    {
        /// <summary>
        /// Check if Square operation returns correct results.
        /// </summary>
        /// <param name="operand">An operand.</param>
        /// <param name="result">Expected result.</param>
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(123, 15129)]
        [InlineData(2565, 6579225)]
        public void ReturnCorrectResult(int operand, int result)
        {
            Assert.Equal(result, Operations.Square(operand));
        }
    }
}