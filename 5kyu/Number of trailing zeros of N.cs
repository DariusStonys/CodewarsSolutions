using System;

namespace _5kyu
{
	public class Kata7
	{
		// https://www.codewars.com/kata/52f787eb172a8b4ae1000a34
		// Write a program that will calculate the number of trailing zeros in a factorial of a given number.
		public static int TrailingZeros(int n)
		{
			int fives = 0;

			for (int i = 1; Math.Pow(5, i) <= n; i++)
				fives += (int)(n / Math.Pow(5, i));

			return fives;
		}
	}
}