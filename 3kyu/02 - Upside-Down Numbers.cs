using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu3
{
	public class Kata2
	{
		// https://www.codewars.com/kata/59f98052120be4abfa000304
		// Input: Your function will receive two strings, each comprised of digits representing a positive integer.These two values will represent the upper and lower bounds of a range.
		// Output: Your function must return the number of valid upside down numbers within the range of the two input arguments, including both upper and lower bounds.
		public static double UpsideDown(string x, string y)
		{
			double numberCount;

			// This IF clause optimizes the counting of Upside-Down numbers by using the simplicity of counting the Upside-Down numbers for [0;10^N) range.
			if (x.Length == y.Length)
            {
				numberCount = NumbersInInterval(x, y);
			}
			else
            {
				numberCount = NumbersInPowerOfTenInterval(y.Length - 1) + NumbersInInterval(CreatePowerOfTenString(y.Length), y)
							- NumbersInPowerOfTenInterval(x.Length - 1) - NumbersInInterval(CreatePowerOfTenString(x.Length), x, true);
			}
			return numberCount;
		}

		private static double NumbersInInterval(string lesserNumber, string greaterNumber, bool check = false)
		{
			//var possibleNumbers = new List<string>() { "" };
			var numbersInInterval = new List<string>();

			var possibleNumbers = GetAllDigitVariations(lesserNumber, greaterNumber);
			possibleNumbers = GetMirroredNumbers(possibleNumbers, lesserNumber.Length % 2 == 1);

			foreach (string number in possibleNumbers)
            {
				if (IsLessOrEqual(number, greaterNumber)) numbersInInterval.Add(number);
			}

			double x = (check && numbersInInterval.LastOrDefault() == greaterNumber) ? numbersInInterval.Count() - 1 : numbersInInterval.Count();

			return x;
		}

		// This loop optimizes the counting of Upside-Down numbers by checking whether any permutations are possible at all at the beginning of the string.
		private static List<string> GetAllDigitVariations(string lesserNumber, string greaterNumber)
        {
			var possibleNumbers = new List<string>() { "" };
			bool greaterDigitFound = false;
			
			for (int i = 0; i * 2 < lesserNumber.Length; i++)
			{
				var validDigits = new List<int>();

				if (greaterDigitFound)
				{
					possibleNumbers = GetSingleDigitVariation(possibleNumbers, possibleDigits[IsMiddleOfString(i, lesserNumber.Length)]);
				}
				else
				{
					foreach (int digit in possibleDigits[IsMiddleOfString(i, lesserNumber.Length)])
					{
						if (GetInteger(lesserNumber[i]) <= digit && digit <= GetInteger(greaterNumber[i]))
						{
							validDigits.Add(digit);
						}
					}
					possibleNumbers = GetSingleDigitVariation(possibleNumbers, validDigits);
					if (!possibleNumbers.SequenceEqual(new List<string>() { "" })) greaterDigitFound = true;
				}
			}
			return possibleNumbers;
		}

		private static List<string> GetSingleDigitVariation(List<string> possibleNumbers, List<int> digits)
		{
			var variedNumbers = new List<string>();

			for (int i = 0; i < possibleNumbers.Count; i++)
            {
				foreach (int digit in digits)
                {
					variedNumbers.Add(possibleNumbers[i] + digit);
				}
            }
			return variedNumbers;
		}

		private static List<string> GetMirroredNumbers(List<string> possibleNumbers, bool isOdd)
		{
			var result = new List<string>();

			foreach (string number in possibleNumbers)
			{
				string mirroredNumber = number;

				for (int i = number.Length - 1 - Convert.ToInt32(isOdd); i >= 0; i--)
				{
					if (number[i] == '6') mirroredNumber += '9';
					else if (number[i] == '9') mirroredNumber += '6';
					else mirroredNumber += number[i];
				}
				result.Add(mirroredNumber);
			}
			return result;
		}

		// This method represents a mathematical equation for Upside-Down numbers within the [0, 10^N) range derived using combinatorics, and is used for the sake of optimization.
		private static double NumbersInPowerOfTenInterval(int n)
		{
			if (n == 0) return 0;

			double x = (2 - n % 2) * 4 * (double)Math.Pow(5, (n - 1) / 2) - 1; //obsolete
			return x;
		}

		private static bool IsLessOrEqual(string lesserNumber, string greaterNumber)
		{
			for (int i = 0; i < lesserNumber.Length; i++)
			{
				if (GetInteger(lesserNumber[i]) < GetInteger(greaterNumber[i])) return true;
				if (GetInteger(lesserNumber[i]) > GetInteger(greaterNumber[i])) return false;
			}
			return true; // Strings are equal
		}

		private static int GetInteger(char c) => int.Parse(char.GetNumericValue(c).ToString());

		private static string CreatePowerOfTenString(int n) => n == 1 ? "0" : ("1" + new string('0', n - 1));

		private static int IsMiddleOfString(int index, int length) => Convert.ToInt32(index * 2 + 1 == length);

		private static readonly List<List<int>> possibleDigits = new List<List<int>>
		{
			new List<int> { 0, 1, 6, 8, 9 },
			new List<int> { 0, 1, 8 }
		};
	}
}