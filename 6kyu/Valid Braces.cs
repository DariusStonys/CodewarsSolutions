namespace _6kyu
{
	public class Kata5
	{
		// https://www.codewars.com/kata/5277c8a221e209d3f6000b56
		// Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.
		public static bool AreBracesValid(string braces)
		{
			int i, j, k;

			while (braces.Length > 0)
			{
				i = braces.IndexOf("()");
				if (i >= 0)
				{
					braces = braces.Remove(i, 2);
					continue;
				}

				j = braces.IndexOf("{}");
				if (j >= 0)
				{
					braces = braces.Remove(j, 2);
					continue;
				}

				k = braces.IndexOf("[]");
				if (k >= 0)
				{
					braces = braces.Remove(k, 2);
					continue;
				}

				if (i == -1 & j == -1 & k == -1) return false;
			}

			return true;
		}
	}
}