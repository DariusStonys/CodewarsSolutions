using System;
using System.Diagnostics;

class ConsoleSpace
{
    static void Main()
    {
        //var input = Convert.ToInt32(Console.ReadLine());
        //var input = Console.ReadLine();
        var input = "12";

        Stopwatch sw = new Stopwatch();
        sw.Start();

        var result = Kyu4.Kata8.GetPINs(input);

        Console.WriteLine("Result: {0}", result);
        //foreach (var item in result) Console.WriteLine(item);

        sw.Stop();
        Console.WriteLine("Time taken: {0}", sw.Elapsed);
        Console.ReadKey();
    }
}