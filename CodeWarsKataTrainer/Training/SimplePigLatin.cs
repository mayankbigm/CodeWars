using System;
using System.Linq;

namespace Training
{
    public static class SimplePigLatin
    {
        public static string PigIt(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException(s);
            }

            Console.WriteLine(s);

            var result = s.Split(" ")
                .Select(x => char.IsPunctuation(x[0]) ? x : $"{x.Substring(1)}{x.Substring(0, 1)}ay")
                .ToArray();

            return string.Join(" ", result);
        }
    }
}
