using System;
using System.Linq;

namespace Katas.Session._01;

public static class ReverseStringKata
{
    /// <summary>
    /// This method reverses words
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ReverseWords(string input)
    {
        string[] strings = input.Split(' ');
        Array.Reverse(strings);
        string result = strings.First();
        for (int i = 1; i < strings.Length; i++)
        {
            result += " " + strings[i];
        }
        return result;
    }
}
