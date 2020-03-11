namespace _4kyu
{
	public class Kata11
	{
		// https://www.codewars.com/kata/52742f58faf5485cae000b9a
		// Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.
		public static string FormatDuration(int seconds)
		{
			if (seconds == 0) return "now";

			string formatedDuration = "";
			string[] standardNames = new[] { "year", "day", "hour", "minute", "second" };
			int[] standardTimes = new[] { 31536000, 86400, 3600, 60, 1 };
			int[] convertedTimes = new int[5];
			string[] convertedTimesWithNames = new string[5];

			for (int i = 0; i < 5; i++)
			{
				convertedTimes[i] = (int)(seconds / standardTimes[i]);

				if (convertedTimes[i] != 0)
				{
					convertedTimesWithNames[i] = convertedTimes[i].ToString() + " " + standardNames[i] + (convertedTimes[i] == 1 ? "" : "s");
					formatedDuration += convertedTimesWithNames[i].ToString() + ", ";
					seconds -= convertedTimes[i] * standardTimes[i];
				}
			};

			formatedDuration = formatedDuration.Remove(formatedDuration.Length - 2);
			int indexLastComma = formatedDuration.LastIndexOf(", ");
			if (indexLastComma != -1)
				formatedDuration = formatedDuration.Remove(indexLastComma, 1).Insert(indexLastComma, " and");

			return formatedDuration;
		}
	}
}
