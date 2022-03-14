using System;
using System.Collections.Generic;
using System.Linq;

namespace Kyu4
{
    public class Kata10
    {
        // https://www.codewars.com/kata/52b7ed099cdc285c300001cd
        // Write a function that accepts an array of intervals, and returns the sum of all the interval lengths. Overlapping intervals should only be counted once.

        public static int SumIntervals((int First, int Second)[] intervals)
        {
            var orderedIntervals = intervals.OrderBy(i => i.First).ToList();
            var disconnectedIntervals = new List<(int First, int Second)>();

            for (int i = 0; i < orderedIntervals.Count(); i++)
            {
                if (i + 1 < orderedIntervals.Count() && orderedIntervals[i].Second >= orderedIntervals[i + 1].First)
                {
                    int j = 0;
                    int maxInterval = orderedIntervals[i].Second;

                    while (i + j + 1 < orderedIntervals.Count() && maxInterval >= orderedIntervals[i + j + 1].First)
                    {
                        maxInterval = Math.Max(maxInterval, orderedIntervals[i + j + 1].Second);
                        j++;
                    }
                    disconnectedIntervals.Add((orderedIntervals[i].First, maxInterval));
                    i += j;
                }
                else
                {
                    disconnectedIntervals.Add(orderedIntervals[i]);
                }
            }
            return disconnectedIntervals.Aggregate(0, (s, x) => s + x.Second - x.First);
        }
    }
}