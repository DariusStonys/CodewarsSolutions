using System.Linq;

namespace Kyu4
{
    public class Kata8
    {
        // https://www.codewars.com/kata/51c8e37cee245da6b40000bd
        // Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should also be stripped out.

        public static string StripComments(string text, string[] commentSymbols)
        {
            var textLines = text
                .Split("\n")
                .Select(line => line.Split(commentSymbols, 0).First().TrimEnd());
            return string.Join("\n", textLines);
        }
    }
}