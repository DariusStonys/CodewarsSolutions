namespace Kyu7
{
	public class Kata1
	{
		// https://www.codewars.com/kata/56606694ec01347ce800001b
		// Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of given length and false in any other case.
		public static bool IsTriangle(int a, int b, int c) => a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
	}
}