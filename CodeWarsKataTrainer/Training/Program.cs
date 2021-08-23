using System;
using System.Collections.Generic;

namespace Training
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Begin!");

            // Simple Pig Latin
            var result = SimplePigLatin.PigIt("Hello world !");
            Console.WriteLine(result);

            //LineTickets
            //var result = LineTickets.Tickets(new int[] { 25, 25, 50, 100, 25, 50, 25, 100, 25, 50, 25, 100, 25, 50, 25, 100, 50, 50 });

            //HighAndLowNumbers
            //var result = HighestLowestNumbersInString.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");

            // ListFilterer
            //ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"});

            // CreatePhoneNumber
            //FormatPhoneNumber.CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0});

            Console.WriteLine("End!");
        }
    }
}
