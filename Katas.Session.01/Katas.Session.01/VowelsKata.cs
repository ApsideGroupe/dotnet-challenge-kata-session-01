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
        int output = 0;
        HashSet<char> voyelles = ['a', 'e', 'i', 'o', 'u'];

        for (int i = 0; i < input.Length; i++)
            if (voyelles.Contains(input[i]))
                output++;

        return output;
    }
}

