using System;
using System.Collections.Generic;
using System.Diagnostics;

#pragma warning disable SA1300

namespace Gcd.Version_3.Interfaces
{
    /// <summary>
    /// extended functionality of interface.
    /// </summary>
    internal class TimerAlgorithm : AlgorithmExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimerAlgorithm"/> class.
        /// </summary>
        /// <param name="algorithm">Some algorithm.</param>
        public TimerAlgorithm(IAlgorithm algorithm) : base(algorithm)
        {
        }

        /// <summary>
        /// Gets the running time of the algorithm.
        /// </summary>
        public long Milliseconds { get; private set; }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        public override int Calculate(int first, int second)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        public override int Calculate(int first, int second, int third)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public override int Calculate(int first, int second, params int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
