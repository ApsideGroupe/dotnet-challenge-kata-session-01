using System;
using System.Linq;

namespace Katas.Session._01
{
    public static class MultipleKata
    {
        /// <summary>
        /// This method sum all multiples of 3 and 5 below the given value
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Additionally, if the number is negative, return 0.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int SumMultiplesBelow(int input)
        {
            if (input <= 0) return 0;

            return Enumerable
                .Repeat(0, input - 1)
                .Select((value, index) => index + 1)
                .Where(x => x % 3 == 0 || x % 5 == 0)
                .Sum();
        }
    }
}
