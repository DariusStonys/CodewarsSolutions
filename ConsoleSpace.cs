using System;
using System.Collections.Generic;
using System.Diagnostics;

class ConsoleSpace
{
    static void Main()
    {
        //var input = Convert.ToInt32(Console.ReadLine());
        var input = 100;

        Stopwatch sw = new Stopwatch();
        sw.Start();

        //var result = Kyu3.Kata2.UpsideDown("1", "999999999999999999999999999999999999999999");
        var result = Kyu3.Kata2.UpsideDown("1", "99999999999999999999");

        if (result.GetType().IsGenericType || result.GetType().IsArray)
        {
            //foreach (var item in result) Console.WriteLine(item);
        }
        else
        {
            Console.WriteLine("Result: {0}", result);
        }
        
        sw.Stop();
        Console.WriteLine("Time taken: {0}", sw.Elapsed);
        Console.ReadKey();
    }
}