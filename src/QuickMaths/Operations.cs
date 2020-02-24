//-----------------------------------------------------------------------
// <copyright file="Operations.cs" company="PlaceholderCompany">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace QuickMaths
{
    /// <summary>
    /// Class with math operations.
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// Add two integer numbers.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Sum of operands.</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts two integer numbers.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Difference between operands.</returns>
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two integer numbers.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Multiplication of operands.</returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Squares an integer number.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <returns>A square of an operand.</returns>
        public static int Square(int a)
        {
            return a * a;
        }

        /// <summary>
        /// Calculate absolute value of an integer numbers.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <returns>Absolute value of an operand.</returns>
        public static int Abs(int a)
        {
            return a >= 0 ? a : -1 * a;
        }
    }
}