using System;
using System.Text;
using System.Numerics;

namespace _3kyu
{
	public class KataNotDone2
	{
		// https://www.codewars.com/kata/59f98052120be4abfa000304
		// Input: Your function will receive two strings, each comprised of digits representing a positive integer.These two values will represent the upper and lower bounds of a range.
		// Output: Your function must return the number of valid upside down numbers within the range of the two input arguments, including both upper and lower bounds.
		public static int UpsideDown(string x, string y)
		{
			int xLength = x.Length;
			int yLength = y.Length;

			int difference = NumbersInDecimalInterval(yLength) - NumbersInDecimalInterval(xLength);

			int numberCount = 0;
			bool digitWasSame = false;

			for (int i = 0; 2 * i <= xLength; i++)
			{
				int add;
				if (i == 0) add = 4;
				else if (2 * i == xLength - 1) add = 3;
				else add = 5;

				StringBuilder mutableX = new StringBuilder(x);
				StringBuilder mutableY = new StringBuilder(y);

				if (digitWasSame && mutableX[i] == mutableY[i]) digitWasSame = true;
				else digitWasSame = false;

				if (ToInt(mutableX[i]) < 1 && 1 < ToInt(mutableY[i])) add++;
				if (ToInt(mutableX[i]) < 6 && 6 < ToInt(mutableY[i])) add++;
				if (ToInt(mutableX[i]) < 8 && 8 < ToInt(mutableY[i])) add++;

				numberCount *= add;
				//mutableX[x.Length - 1 - i] = '1';
				//Console.WriteLine(mutableX);

				//if (CompareStrings(mutableX.ToString(), x)) Console.WriteLine(mutableX);

			}

			return numberCount + difference;
		}

		private static bool CompareStrings(string a, string b) => BigInteger.Parse(b) > BigInteger.Parse(a);

		public static int ToInt(char a) => int.Parse(a.ToString());

		// This method is a mathematical equation for upside down numbers withing the range [0, 10^(n.length)], derived using combinatorics; and is used for the sake of optimization.
		private static int NumbersInDecimalInterval(int n)
		{
			bool even = n > 0 && n % 2 == 0;
			int m = n > 1 ? (n - 1) / 2 : 0;

			return (1 + Convert.ToInt32(even)) * 4 * (int)Math.Pow(5, m) - 1;
		}
	}
}