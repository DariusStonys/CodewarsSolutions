using System;

namespace Kyu5
{
	public class Kata3
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
	}
}