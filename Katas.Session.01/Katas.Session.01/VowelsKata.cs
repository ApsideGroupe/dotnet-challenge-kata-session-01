using System;
using System.Collections.Generic;

namespace Katas.Session._01;

public static class VowelsKata
{
    /// <summary>
    /// This method counts number of vowels in the given string
    /// We will consider a, e, i, o, u as vowels for this Kata (but not y).
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int CountVowels(string input)
    {
        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        int count = 0;
        foreach (char item in input)
        {
            if (vowels.Contains(item))
                count++;
        }
        return count;
    }
}

