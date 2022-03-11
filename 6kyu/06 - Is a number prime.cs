namespace Kyu6
{
	public class Kata6
	{
		// https://www.codewars.com/kata/5262119038c0985a5b00029f
		// Define a function that takes an integer argument and returns logical value true or false depending on if the integer is a prime.
		public static bool IsPrime(int n)
		{
			for (int i = 2; i * i <= n; i++)
			{
				if (n % i == 0) return false;
			}

			return true;
		}
	}
}