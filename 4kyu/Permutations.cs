using System;
using System.Collections.Generic;

namespace _4kyu
{
	public class Kata12
	{
		// https://www.codewars.com/kata/5254ca2719453dcc0b00027d
		// In this kata you have to create all permutations of an input string and remove duplicates, if present. This means, you have to shuffle all letters from the input in all possible orders.
		public static List<string> SinglePermutations(string s)
		{
			var builtStrings = new List<string>();
			char[] builder = s.ToCharArray();

			Permute(builder, 0, s.Length - 1, builtStrings);

			builtStrings.Sort();
			RemoveDuplicates(builtStrings);

			return builtStrings;
		}

		static void Permute(char[] builder, int start, int end, List<string> builtStrings)
		{
			if (start == end)
			{
				string stringifiedBuilder = "";

				for (int i = 0; i < builder.Length; i++)
				{
					stringifiedBuilder += builder[i];
				}
				
				builtStrings.Add(stringifiedBuilder);
			}

			for (int i = start; i <= end; i++)
			{
				Swap(ref builder[start], ref builder[i]);
				Permute(builder, start + 1, end, builtStrings);
				Swap(ref builder[start], ref builder[i]);
			}
		}

		private static void Swap(ref char a, ref char b)
		{
			if (a != b)
			{
				char temp = a;
				a = b;
				b = temp;
			}
		}
		
		private static void RemoveDuplicates(List<string> list)
		{
			int length = list.Count - 1;

			for (int i = 1; i <= length; i++)
			{
				if (list[i - 1] == list[i])
				{
					list.RemoveAt(i);
					i--;
					length--;
				}
			}
		}
	}
}
