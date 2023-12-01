using System;
using System.Diagnostics;

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
            return third == 0 ? algorithm.Invoke(first, second) : algorithm.Invoke(algorithm.Invoke(first, third), second);
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
            int gcd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    continue;
                }

                gcd = algorithm.Invoke(gcd, numbers[i]);
            }

            if (gcd == 0)
            {
                return algorithm.Invoke(first, second);
            }

            return algorithm.Invoke(algorithm(gcd, second), first);
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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int gcd = algorithm.Invoke(first, second);

            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;

            return gcd;
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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int gcd = algorithm.FindGcdWithThreeParameters(first, second, third);

            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;

            return gcd;
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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int gcd = algorithm.FindGcdAlgorithm(first, second, numbers);

            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;

            return gcd;
        }
    }
}
