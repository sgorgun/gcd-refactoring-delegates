using System;
using Gcd.Version_2.Interfaces;

#pragma warning disable SA1300

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
            if (first == int.MinValue || second == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (first == 0 && second == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            first = Math.Abs(first);
            second = Math.Abs(second);
            if (first == second)
            {
                return first;
            }

            if (first == 0)
            {
                return second;
            }

            if (second == 0)
            {
                return first;
            }

            if ((~first & 1) == 1)
            {
                if ((second & 1) == 1)
                {
                    return this.Calculate(first >> 1, second);
                }
                else
                {
                    return this.Calculate(first >> 1, second >> 1) << 1;
                }
            }

            if ((~second & 1) == 1)
            {
                return this.Calculate(first, second >> 1);
            }

            if (first > second)
            {
                return this.Calculate((first - second) >> 1, second);
            }

            return this.Calculate((second - first) >> 1, first);
        }
    }
}
