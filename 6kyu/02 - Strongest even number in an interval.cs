using System;

namespace Kyu6
{
	public class Kata2
	{
		// https://www.codewars.com/kata/5d16af632cf48200254a6244
		// A strongness of an even number is the number of times we can successively divide by 2 until we reach an odd number starting with an even number n.
		// Given a closed interval[n, m], return the even number that is the strongest in the interval. If multiple solutions exist return the smallest strongest even number.
		public static int StrongestEven(int n, int m)
		{
            int strongestEvenNumber;
            do
			{
				strongestEvenNumber = n;
				n += (int)Math.Pow(2, ExtractPowersOf2(n));
			}
			while (n > 0 && n <= m);

			return strongestEvenNumber;
		}

		public static int ExtractPowersOf2(int i)
		{
			int power = 0;

			while (i % 2 == 0)
			{
				power++;
				i /= 2;
			};

			return power;
		}
	}
}