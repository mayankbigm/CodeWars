using System;
using System.Linq;
using System.Text;

public class FormatPhoneNumber{

    // Write a function that acccepts an arrary of 10 integers (between 0 and 9),
    // that returns a string of those numbers in the form of a phone number 
    // Example Kata.CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0}) // => returns "(123) 456-7890"

    // Best answers: https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/solutions/csharp
    public static void CreatePhoneNumber(int[] numbers){
        if(numbers.Length != 10){
            throw new ArgumentOutOfRangeException(nameof(numbers), "Input array must be exactly 10 numbers");
        }

        if (!numbers.All(x => x<=9 && x>=0))
        {
            throw new ArgumentOutOfRangeException(nameof(numbers), "Input array must be between numbers 0 and 9, both inclusive");
        }

        StringBuilder sb = new StringBuilder();
        sb.Append("(");

        for (int i = 0; i < numbers.Length; i++)
        {
            switch (i)
            {
                case 2:
                    sb.Append($"{numbers[i]}) ");
                    continue;
                case 5:
                    sb.Append($"{numbers[i]}-");
                    continue;
            }

            sb.Append(numbers[i]);
        }

        Console.WriteLine(sb.ToString());
    }
}