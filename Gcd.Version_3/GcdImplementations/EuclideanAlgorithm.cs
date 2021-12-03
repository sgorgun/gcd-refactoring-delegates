using System;
using Gcd.Version_3.Interfaces;

#pragma warning disable SA1300

namespace Gcd.Version_3.GcdImplementations
{
    /// <inheritdoc/>
    internal class EuclideanAlgorithm : IAlgorithm
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
