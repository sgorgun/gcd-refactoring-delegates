﻿using System;
using System.Collections.Generic;
using Gcd.Version_1.GcdImplementations;
using Gcd.Version_1.Interface;

namespace Gcd.Version_1.StaticClasses
{
    /// <summary>
    /// Provide methods to calculates GCD.
    /// </summary>
    public static class GcdAlgorithms
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int first, int second) =>
            Gcd(new EuclideanAlgorithm(), first, second);

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int first, int second, int third) =>
            Gcd(new EuclideanAlgorithm(), first, second, third);

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int first, int second, params int[] numbers) =>
            Gcd(new EuclideanAlgorithm(), first, second, numbers);

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long milliseconds, int first, int second) =>
            Gcd(new EuclideanAlgorithm(), out milliseconds, first, second);

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long milliseconds, int first, int second, int third) =>
            Gcd(new EuclideanAlgorithm(), out milliseconds, first, second, third);

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long milliseconds, int first, int second, params int[] numbers) =>
            Gcd(new EuclideanAlgorithm(), out milliseconds, first, second, numbers);

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int first, int second) =>
            Gcd(new SteinAlgorithm(), first, second);

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int first, int second, int third) =>
            Gcd(new SteinAlgorithm(), first, second, third);

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int first, int second, params int[] numbers) =>
            Gcd(new SteinAlgorithm(), first, second, numbers);

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long milliseconds, int first, int second) =>
            Gcd(new SteinAlgorithm(), out milliseconds, first, second);

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long milliseconds, int first, int second, int third) =>
            Gcd(new SteinAlgorithm(), out milliseconds, first, second, third);

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long milliseconds, int first, int second, params int[] numbers) =>
            Gcd(new SteinAlgorithm(), out milliseconds, first, second, numbers);

        private static int Gcd(Algorithm algorithm, int first, int second) => algorithm.Calculate(first, second);

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second) =>
            algorithm.Calculate(first, second, out milliseconds);

        private static int Gcd(Algorithm algorithm, int first, int second, int third)
        {
            int gcd;
            if (first == 0 && second == 0)
            {
                gcd = algorithm.Calculate(second, third);
            }
            else
            {
                int gcdtwonumbers = algorithm.Calculate(first, second);
                gcd = algorithm.Calculate(gcdtwonumbers, third);
            }

            return gcd;
        }

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second, int third)
        {
            int gcd;
            long time;
            milliseconds = 0;
            if (first == 0 && second == 0)
            {
                gcd = algorithm.Calculate(second, third, out time);
            }
            else
            {
                int gcdtwonumbers = algorithm.Calculate(first, second, out time);
                milliseconds += time;
                gcd = algorithm.Calculate(gcdtwonumbers, third, out time);
            }

            milliseconds += time;
            return gcd;
        }

        private static int Gcd(Algorithm algorithm, int first, int second, params int[] numbers) 
        {
            List<int> otherWithoutZero = new List<int>();
            int gcd = 0;

            foreach (int n in numbers)
            {
                if (n != 0)
                {
                    otherWithoutZero.Add(n);
                }
            }

            if (first != 0 || second != 0)
            {
                gcd = algorithm.Calculate(first, second);
            }
            else
            {
                if (otherWithoutZero.Count == 0)
                {
                    throw new ArgumentException("All numbers cannot be 0 at the same time.");
                }
            }

            for (int j = 0; j < otherWithoutZero.Count; j++)
            {
                gcd = algorithm.Calculate(otherWithoutZero[j], gcd);
            }

            return gcd;
        }

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second, params int[] numbers)
        {
            int gcd = 0;
            long time;
            milliseconds = 0;
            List<int> otherWithoutZero = new List<int>();

            foreach (int n in numbers)
            {
                if (n != 0)
                {
                    otherWithoutZero.Add(n);
                }
            }

            if (first != 0 || second != 0)
            {
                gcd = algorithm.Calculate(first, second, out time);
                milliseconds += time;
            }
            else
            {
                if (otherWithoutZero.Count == 0)
                {
                    throw new ArgumentException("All numbers cannot be 0 at the same time.");
                }
            }

            for (int j = 0; j < otherWithoutZero.Count; j++)
            {
                gcd = algorithm.Calculate(otherWithoutZero[j], gcd, out time);
                milliseconds += time;
            }

            return gcd;
        }
    }
}