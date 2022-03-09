namespace _6kyu
{
	public class Kata8
	{
		// https://www.codewars.com/kata/5842df8ccbd22792a4000245/
		// You will be given a number and you will need to return it as a string in Expanded Form.
		public static string ExpandedForm(long num)
		{
			var resultString = "";
			var zeroes = "";
			char[] numberList = num.ToString().ToCharArray();

			for (int i = 0; i < numberList.Length; i++)
			{
				zeroes = "";
				if (i == 0 || numberList[i].ToString() != "0")
				{
					for (int j = 1; j < numberList.Length - i; j++)
						zeroes += "0";

					resultString += numberList[i] + zeroes + " + ";
				}
			}

			return (resultString.Length > 3) ? resultString.Remove(resultString.Length - 3) : resultString;
		}
	}
}