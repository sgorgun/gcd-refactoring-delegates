﻿using System;
using Gcd.Version_1.Interface;

#pragma warning disable SA1300

namespace Gcd.Version_1.GcdImplementations
{
    /// <summary>
    /// Calculates the GCD by the Stein algorithm.
    /// </summary>
    internal class SteinAlgorithm : Algorithm
    {
        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        protected override int Func(int first, int second)
        {
            throw new NotImplementedException();
        }
    }
}
