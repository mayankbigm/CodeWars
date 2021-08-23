using System;
using System.Linq;

namespace Training
{
    /*
     * https://www.codewars.com/kata/550498447451fbbd7600041c
     * Given two arrays a and b write a function comp(a, b) (orcompSame(a, b))
     * that checks whether the two arrays have the "same" elements, with the same multiplicities.
     * "Same" means, here, that the elements in b are the elements in a squared, regardless of the order.
     */
    public static class AreTheyTheSame
    {
        public static bool Compare(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            if (a.Length != b.Length)
            {
                return false;
            }

            Console.WriteLine("a = " + string.Join(", ", a));
            Console.WriteLine("b = " + string.Join(", ", b));

            return a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }
    }
}
