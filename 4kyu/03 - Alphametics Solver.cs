using System;
using System.Collections.Generic;

namespace Kyu4
{
	public class Kata3
	{
		// https://www.codewars.com/kata/5b5fe164b88263ad3d00250b
		// Alphametics is a type of cryptarithm in which a set of words is written down in the form of a long addition sum or some other mathematical problem. The objective is to replace the letters of the alphabet with decimal digits to make a valid arithmetic sum.
		// For this kata, your objective is to write a function that accepts an alphametic equation in the form of a single-line string and returns a valid arithmetic equation in the form of a single-line string.
		public class Cryptarithm
		{
			public static string Alphametics(string s)
			{
				Alphametic alphametic = new Alphametic(s);
				return alphametic.ConvertToOutputString();
			}
		}

		public class Alphametic
		{
			public string input;
			public string output;

			//public List<char[]> summands;
			//public char[] sum;
			public string[] summandsWord;
			public string sumWord;
			
			public int[] summands;
			public int sum;

			public Alphametic(string s)
			{
				s = s[1..^2]; //s.Substring(1, s.Length - 2);

				summandsWord = s.Split(" = ")[0].Split(" + ");
				sumWord = s.Split(" = ")[1];

				//summands = sumWord.ConvertToOutputString();

			}

			public string Get()
			{
				Get();
				return output;
			}

			public string ConvertToOutputString()
			{
				output = "\"";
				for (int i = 0; i < summands.Length; i++)
				{
					output += " + " + summands[i].ToString();
				}
				output += "\" = " + sum.ToString();
				return output;
			}
		}


	}


}
