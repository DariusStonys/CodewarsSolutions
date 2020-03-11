using System.Collections.Generic;

namespace _6kyu
{
	public class Kata6
	{
		// https://www.codewars.com/kata/54da5a58ea159efa38000836
		// Given an array, find the integer that appears an odd number of times.

		public static int FindTheOddInt(int[] seq)
		{
			// sort the array
			bool didSwap;

			do
			{
				didSwap = false;
				for (int i = 0; i < seq.Length - 1; i++)
				{
					if (seq[i] > seq[i + 1])
					{
						int temp = seq[i + 1];
						seq[i + 1] = seq[i];
						seq[i] = temp;
						didSwap = true;
					}
				}
			} while (didSwap);

			//compare pairs of values
			int j = 0;

			while (j < seq.Length - 1)
			{
				if (seq[j] != seq[j + 1]) return seq[j];
				j += 2;
			}

			return seq[seq.Length - 1];
		}

		// or, if we could use System.Collections.Generic:
		public static int FindTheOddIntWithCollections(int[] seq)
		{
			var occurrences = new Dictionary<int, int>();

			for (int i = 0; i < seq.Length; i++)
			{
				if (occurrences.ContainsKey(seq[i])) occurrences[seq[i]]++;
				else occurrences.Add(seq[i], 1);
			}

			foreach (KeyValuePair<int, int> pair in occurrences)
				if (pair.Value % 2 == 1) return pair.Key;

			return 0;
		}
	}
}