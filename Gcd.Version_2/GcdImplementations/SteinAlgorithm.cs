using System;
using Gcd.Version_2.Interfaces;

namespace Gcd.Version_2.GcdImplementations
{
    /// <inheritdoc/>
    internal class SteinAlgorithm : IAlgorithm
    {
        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public int Calculate(int first, int second)
        {
            throw new NotImplementedException();
        }
    }
}
