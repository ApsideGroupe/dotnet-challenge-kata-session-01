using System;

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
        string lowerCaseInput = input.ToLower();

        int count = 0;

        string vowels = "aeiou";

        foreach (char c in lowerCaseInput) 
        {
            if (vowels.Contains(c)) 
            {
                count++;
            }
        }

        return count;
    }
}

