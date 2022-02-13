using System;

namespace Gcd.Version_3.Interfaces
{
    /// <summary>
    /// extended functionality of interface.
    /// </summary>
    internal class ParamsAlgorithm : AlgorithmExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParamsAlgorithm"/> class.
        /// </summary>
        /// <param name="algorithm">Some algorithm.</param>
        public ParamsAlgorithm(IAlgorithm algorithm)
            : base(algorithm)
        {
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        public override int Calculate(int first, int second) => this.algorithm.Calculate(first, second);

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
