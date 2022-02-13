using System;

namespace Gcd.Version_3.Interfaces
{
    internal abstract class AlgorithmExtension : IAlgorithm
    {
        protected readonly IAlgorithm algorithm;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AlgorithmExtension"/> class.
        /// </summary>
        /// <param name="algorithm">Some algorithm.</param>
        protected AlgorithmExtension(IAlgorithm algorithm)
        {
            this.algorithm = algorithm ?? throw new ArgumentNullException(nameof(algorithm));
        }
        
        public abstract int Calculate(int first, int second);

        public abstract int Calculate(int first, int second, int third);

        public abstract int Calculate(int first, int second, params int[] numbers);
    }
}
