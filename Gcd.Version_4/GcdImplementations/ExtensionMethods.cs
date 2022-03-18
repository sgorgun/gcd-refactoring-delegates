using System;

namespace Gcd.Version_4.GcdImplementations
{
    /// <summary>
    /// Implementation extension methods.
    /// </summary>
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Extension method for calculate the GCD of integers [-int.MaxValue;int.MaxValue].
        /// </summary>
        /// <param name="algorithm">Algorithm for calculate.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        internal static int FindGcdWithThreeParameters(this Func<int, int, int> algorithm, int first, int second, int third)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Extension method for calculate the GCD of integers [-int.MaxValue;int.MaxValue].
        /// </summary>
        /// <param name="algorithm">Algorithm for calculate.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        internal static int FindGcdAlgorithm(this Func<int, int, int> algorithm, int first, int second, params int[] numbers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Extension method for calculate GCD of two integers from[-int.MaxValue; int.MaxValue] by the algorithm with milliseconds time.
        /// </summary>
        /// <param name="algorithm">Algorithm for calculate.</param>       
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param> 
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <returns>The GCD value.</returns>
        internal static int FindGcdWithTimeWorkingAlgorithm(this Func<int, int, int> algorithm, int first, int second, out long milliseconds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Extension method for calculate GCD of three integers from[-int.MaxValue; int.MaxValue] by the algorithm with milliseconds time.
        /// </summary>
        /// <param name="algorithm">Algorithm for calculate.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>      
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <returns>The GCD value.</returns>
        internal static int FindGcdWithThreeParametersTimeWorkingAlgorithm(this Func<int, int, int> algorithm, int first, int second, int third, out long milliseconds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Extension method for calculate GCD of integers from[-int.MaxValue; int.MaxValue] by the algorithm with milliseconds time.
        /// </summary>
        /// <param name="algorithm">Algorithm for calculate.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="numbers">Other integers.</param>        
        /// <returns>The GCD value.</returns>
        internal static int FindGcdWithParamsAndTimeWorkingAlgorithm(this Func<int, int, int> algorithm, int first, int second, out long milliseconds, params int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
