using System.Text.RegularExpressions;

namespace Kyu5
{
	public class Kata2
	{
		// https://www.codewars.com/kata/52774a314c2333f0a7000688
		// Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.
		public static bool ValidParentheses(string input)
		{
			input = Regex.Replace(input, "[^(-)]+", "");

			string previous = "";
			while (previous != input)
			{
				previous = input;
				input = input.Replace("()", "");
			}

			return input.Length == 0;
		}
	}
}