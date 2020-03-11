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
			int xlength = x.Length;
			int ylength = y.Length;

			int difference = NumbersInDecimalInterval(ylength) - NumbersInDecimalInterval(xlength);

			int numberCount = 0;

			for (int i = 0; 2 * i <= x.Length; i++)
			{
				StringBuilder mutableX = new StringBuilder(x);
				mutableX[i] = '1';
				mutableX[x.Length - 1 - i] = '1';
				Console.WriteLine(mutableX);

				//if (CompareStrings(mutableX.ToString(), x)) Console.WriteLine(mutableX);

				//for (int j = 0; 2 * i <= x.Length; j++) 
				//{
				//	if (j != i)
				//	{

				//	}

				//	for (int k = 0; 2 * i <= x.Length; k++)
				//	{
				//		if (k != j && k != i)
				//		{

				//		}

				//		for (int l = 0; 2 * i <= x.Length; l++)
				//		{
				//			if (l != k && l != j && l != i)
				//			{

				//			}
				//		}
				//	}
				//}
			}

			return numberCount;
		}

		private static bool CompareStrings(string a, string b) => BigInteger.Parse(b) > BigInteger.Parse(a);

		// This method is a mathematical equation for upside down numbers withing the range [0, 10^(n.length)], derived using combinatorics; and is used for the sake of optimization.
		private static int NumbersInDecimalInterval(int n)
		{
			bool even = n > 0 && n % 2 == 0;
			int m = n > 1 ? (n - 1) / 2 : 0;

			return (1 + Convert.ToInt32(even)) * 4 * (int)Math.Pow(5, m) - 1;
		}
	}
}