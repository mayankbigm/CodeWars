using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Training
{
    /// <summary>
    ///  given a string of space separated numbers, and have to return the highest and lowest number.
    /// Example:
    /// Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
    /// Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
    /// Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
    /// </summary>
    public static class HighestLowestNumbersInString
    {
        public static string HighAndLow(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            var digits = numbers.Split(" ").Select(int.Parse).ToList();
            return $"{digits.Max()} {digits.Min()}";
        }
    }
}
