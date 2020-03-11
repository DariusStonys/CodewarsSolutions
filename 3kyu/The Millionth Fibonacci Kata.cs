using System;
using System.Numerics;

namespace _3kyu
{
	public class KataNotDone1
	{
		// https://www.codewars.com/kata/53d40c1e2f13e331fc000c26
		// In this kata you will have to calculate fib(n). Write an algorithm that can handle n up to 2000000.
		public static BigInteger Fibonacci(int n)
		{
			bool negative = false;

			if (n < 0)
			{
				negative = true;
				n = -n;
			}

			BigInteger fibonacciNumber = (BigInteger)Math.Round((Math.Pow((1 + Math.Sqrt(5)) / 2, n) / Math.Sqrt(5)));

			if (negative)
				return (n % 2 == 0 ? -1 : 1) * fibonacciNumber;
			else
				return fibonacciNumber;
		}
	}
}
