namespace _6kyu
{
	public class Kata1
	{
		// https://www.codewars.com/kata/541c8630095125aba6000c00
		// In this kata, you must create a digital root function.
		// A digital root is the recursive sum of all the digits in a number. Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced.This is only applicable to the natural numbers.
		public static long SumOfDigits(long n)
		{
			long sum = 0;

			do
			{
				sum += n % 10;
				n = n / 10;
			}
			while (n > 0);

			return sum;
		}
	}
}