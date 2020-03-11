using System;

namespace _5kyu
{
	public class Kata10
	{
		// https://www.codewars.com/kata/54d512e62a5e54c96200019e
		// Given a positive number n > 1 find the prime factor decomposition of n. The result will be a string with the following form : "(p1**n1)(p2**n2)...(pk**nk)"
		public static String Factors(int lst)
		{
			string factors = "";

			for (int i = 2; i <= lst; i++)
			{
				int j = 0;

				while (lst % i == 0)
				{
					lst /= i;
					j++;
				}

				if (j > 0)
					factors += ("(" + i + (j == 1 ? "" : "**" + j) + ")");
			}

			return factors;
		}
	}
}
