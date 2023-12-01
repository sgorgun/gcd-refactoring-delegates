using System;

namespace Gcd.Version_4.GcdImplementations
{
    /// <summary>
    /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue].
    /// </summary>
    internal class SteinAlgorithm
    {
        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue].
        /// </summary>
        /// <param name="first">first value.</param>
        /// <param name="second">second value.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public int CalculateGcd(int first, int second)
        {
            if (first == 0 && second == 0)
            {
                throw new ArgumentException("All arguments cannot be zero.(6)");
            }

            if (first == int.MinValue || second == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"One or two numbers are { int.MinValue}.");
            }

            first = first < 0 ? -first : first;
            second = second < 0 ? -second : second;

            while (first != 0 && second != 0)
            {
                if (first > second)
                {
                    first %= second;
                }
                else
                {
                    second %= first;
                }
            }

            return first == 0 ? second : first;
        }
    }
}
