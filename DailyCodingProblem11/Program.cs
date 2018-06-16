using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string[] GetAutoCompleteResult(string prefix, string[] qs)
        {
            var hset = new HashSet<string>(qs, StringComparer.OrdinalIgnoreCase);

            return hset.Where(x => x.Contains(prefix)).ToArray();
        }
    }
}
