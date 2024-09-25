﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Session._01
{
    public static class VowelsKata
    {
        private static List<char> vowelsWanted = ['a', 'e', 'i', 'o', 'u'];

        /// <summary>
        /// This method counts number of vowels in the given string
        /// We will consider a, e, i, o, u as vowels for this Kata (but not y).
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int CountVowels(string input) => input.ToCharArray().Where(vowelsWanted.Contains).Count();
    }
}
