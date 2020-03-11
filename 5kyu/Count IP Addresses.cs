using System;

namespace _5kyu
{
	public class Kata9
	{
		// https://www.codewars.com/kata/526989a41034285187000de4
		// Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).
		public static long IpsBetween(string start, string end) => ParseIP(end) - ParseIP(start);

		public static int ParseIP(string s)
		{
			int n = 0;
			int i = 3;

			foreach (string value in s.Split('.'))
			{
				n += Convert.ToInt32(value) * (int)Math.Pow(256, i);
				i--;
			}

			return n;
		}

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