using System.Linq;

namespace Kyu7
{
	public class Kata3
	{
		public static string OddOrEven(int[] array) => array.Sum() % 2 == 0 ? "even" : "odd";
	}
}