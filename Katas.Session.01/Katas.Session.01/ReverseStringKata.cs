using System;
using System.Collections.Generic;
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
        return String.Join(" ", input.Split(' ').Reverse());
    }
}
