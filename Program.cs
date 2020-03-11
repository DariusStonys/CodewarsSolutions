using System;
using System.Diagnostics;
using _3kyu;
using _4kyu;
using _5kyu;
using _6kyu;
using _7kyu;

class TestSpace
{
	static void Main()
	{
		//var input = Convert.ToInt32(Console.ReadLine());
		var input = Console.ReadLine();
		//var input = 101956166;

		Stopwatch sw = new Stopwatch();
		sw.Start();

		var result = KataNotDone2.UpsideDown("23456", input);

		Console.WriteLine("Result: {0}", result);
		sw.Stop();
		Console.WriteLine("Time taken: {0}", sw.Elapsed);
		Console.ReadKey();
	}
}