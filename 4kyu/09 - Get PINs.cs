using System.Collections.Generic;

namespace Kyu4
{
    public class Kata9
    {
        // https://www.codewars.com/kata/5263c6999e0f40dee200059d
        // A function that returns an array (or a list in C#) of all variations for an observed PIN with a length of 1 to 8 digits.

        public static List<string> GetPINs(string observed)
        {
            var PINs = new List<string>() { "" };

            for (int i = 0; i < observed.Length; i++)
            {
                PINs = GenerateVariations(PINs, int.Parse(observed[i].ToString()));
            }
            return PINs;
        }

        private static List<string> GenerateVariations(List<string> PINs, int digit)
        {
            var variedPINs = new List<string>();

            foreach (string pin in PINs)
            {
                foreach (string variation in digitVariations[digit])
                {
                    variedPINs.Add(pin + variation);
                }
            }
            return variedPINs;
        }

        private static readonly List<List<string>> digitVariations = new List<List<string>>
        {
            new List<string> { "0", "8" },
            new List<string> { "1", "2", "4" },
            new List<string> { "1", "2", "3", "5" },
            new List<string> { "2", "3", "6" },
            new List<string> { "1", "4", "5", "7" },
            new List<string> { "2", "4", "5", "6", "8" },
            new List<string> { "3", "5", "6", "9" },
            new List<string> { "4", "7", "8" },
            new List<string> { "0", "5", "7", "8", "9"},
            new List<string> { "6", "8", "9" }
        };
    }
}