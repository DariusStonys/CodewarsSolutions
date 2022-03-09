using System;
using System.Collections.Generic;
using System.Linq;

namespace _4kyu
{
    public class Kata16
    {
        // https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
        // Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.
        public class RangeExtraction
        {
            public static string Extract(int[] args)
            {
                if (args.Length == 0) return "";

                string result = "";
                var interval = new List<string>() { };

                for (int i = 0; i < args.Length; i++)
                {
                    interval.Add(args[i].ToString());

                    if (i == args.Length - 1 || args[i] + 1 != args[i+1])
                    {
                        result += PrintInterval(interval);
                        interval.Clear();
                    }
                }
                return result.Substring(1);
            }

            public static string PrintInterval(List<string> interval)
            {
                if (interval.Count <= 2) return "," + interval.Aggregate((x, y) => x + "," + y); 
                else return $",{ String.Join("-", new string[] { interval.First(), interval.Last() }) }";
            }
        }
    }
}