using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu4
{
    public class Kata7
    {
        // https://www.codewars.com/kata/55983863da40caa2c900004e
        // Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits.
        public static long NextBiggerNumber(long n)
        {
            var digits = new List<char>();
            digits.AddRange(n.ToString());

            for (int i = digits.Count - 1; i > 0; i--)
            {
                if (digits[i] > digits[i - 1])
                {
                    var rightDigits = digits.Skip(i - 1).ToList();
                    var nextBiggerDigit = rightDigits.Where(d => d > rightDigits.First()).Min();
                    rightDigits.Remove(nextBiggerDigit);
                    rightDigits.Sort();
                    digits.RemoveRange(i - 1, digits.Count - i + 1);
                    digits.Add(nextBiggerDigit);
                    digits.AddRange(rightDigits);

                    return long.Parse(String.Join("", digits));
                }
            }
            return -1;
        }
    }
}