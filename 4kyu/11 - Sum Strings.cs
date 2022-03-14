using System;
using System.Collections.Generic;
using System.Linq;

namespace Kyu4
{
    public class Kata11
    {
        // https://www.codewars.com/kata/5324945e2ece5e1f32000370
        // Given the string representations of two integers, return the string representation of the sum of those integers.

        public static string SumStrings(string a, string b)
        {
            string result = "";
            int remainder = 0;
            (a, b) = MakeSameLength(a, b);

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int sum = remainder + GetInteger(a[i]) + GetInteger(b[i]);
                if (sum > 9)
                {
                    remainder = 1;
                    sum %= 10;
                }
                else
                {
                    remainder = 0;
                }    
                result = String.Concat(sum, result);
            }

            return (remainder == 0) ? RemoveZeroes(result) : String.Concat(1, result);
        }
        private static (string, string) MakeSameLength(string a, string b)
        {
            string zeroes = new string('0', Math.Abs(a.Length - b.Length));

            return (a.Length < b.Length) ? (zeroes + a, b) : (a, zeroes + b);
        }

        private static int GetInteger(char c) => int.Parse(char.GetNumericValue(c).ToString());

        private static string RemoveZeroes(string s)
        {
            int i = -1;
            bool nonZeroFound = false;

            while (!nonZeroFound)
            {
                i++;
                if (s[i] != '0') nonZeroFound = true;
            }
            return s.Substring(i);
        }
    }
}