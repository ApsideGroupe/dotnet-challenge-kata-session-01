using System;
using System.Collections.Generic;

namespace Katas.Session._01;

public static class MinMaxKata
{
    /// <summary>
    /// This method return the min and max value from the given input string. All numbers in the given string are separated by a space
    /// Examples Input: "1 2 3 4 5"   =>  Output: "5 1"
    /// Output string must be two numbers separated by a single space, and highest number is first.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ComputeMinMax(string input)
    {
        List<int> numbers = new List<int>();
        string[] split = input.Split(' ');
        foreach (string item in split)
        {
            numbers.Add(int.Parse(item));
        }
        string result = "";
        numbers.Sort();
        result += numbers[numbers.Count - 1] + " " + numbers[0];
        return result;
    }
}
