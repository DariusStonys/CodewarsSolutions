using System.Linq;

namespace Kyu7
{
	public class Kata2
	{
		// https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
		// Simple, given a string of words, return the length of the shortest word(s).
		public static int FindShort(string s)
		{
			int minLength = s.Length;
			int index = 0;
			s.Split(' ').Min(x => x.Length);
			do
			{
				index = s.IndexOf(" ");
				if (minLength > index && index >= 0) minLength = index;
				if (minLength > s.Length && index == -1) minLength = s.Length;

				s = s.Substring(index + 1);
			}
			while (index > 0);

			return minLength;
		}
	}
}