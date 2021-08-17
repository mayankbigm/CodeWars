using System;
using System.Collections.Generic;

namespace Training
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin!");

            // CreatePhoneNumber
            //FormatPhoneNumber.CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0});

            // ListFilterer
            ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"});

            Console.WriteLine("End!");
        }
    }
}
