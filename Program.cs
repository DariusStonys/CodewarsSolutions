using _4kyu;
using _5kyu;
using System;
using System.Diagnostics;

class TestSpace
{
    static void Main()
    {
        //var input = Convert.ToInt32(Console.ReadLine());
        //var input = Console.ReadLine();
        var input = new[] { -6, -5, -4, -3, -2, 0, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20, 21, 23};
        var input1 = new int[] { 2 };

        Stopwatch sw = new Stopwatch();
        sw.Start();

        var result = Kata16.RangeExtraction.Extract(input);

        Console.WriteLine("Result: {0}", result);
        //foreach (var item in result) Console.WriteLine(item);

        sw.Stop();
        Console.WriteLine("Time taken: {0}", sw.Elapsed);
        Console.ReadKey();
    }    
}