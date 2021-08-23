using System;
using System.Collections.Generic;

namespace Training
{
    public static class LineTickets
    {
        /*
         * The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line.
         * Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.
            Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
            Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?
            Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment. Otherwise return NO.

            Examples:
            Line.Tickets(new int[] {25, 25, 50}) // => YES 
            Line.Tickets(new int[] {25, 100}) // => NO. Vasya will not have enough money to give change to 100 dollars
            Line.Tickets(new int[] {25, 25, 50, 50, 100}) // => NO. Vasya will not have the right bills to give 75 dollars of change (you can't make two bills of 25 from one
            25,50,50
         */
        public static string Tickets(int[] peopleInLine)
        {
            const string no = "NO";
            const string yes = "YES";

            if (peopleInLine == null || peopleInLine.Length == 0)
            {
                return no;
            }

            Console.WriteLine(string.Join(", ", peopleInLine));

            if (peopleInLine[0] != 25)
            {
                return no;
            }

            var cashBox = new Dictionary<int, int>
            {
                {25, 0},
                {50, 0},
                {100, 0}
            };

            foreach (var x in peopleInLine)
            {
                // add
                if (cashBox.ContainsKey(x))
                {
                    cashBox[x]++;
                }

                // remove and return
                switch (x)
                {
                    case 25:
                        break;

                    case 50:
                        if (cashBox[25] == 0)
                        {
                            return no;
                        }

                        cashBox[25]--;
                        break;

                    case 100:
                        if (cashBox[50] > 0 && cashBox[25] > 0)
                        {
                            cashBox[25]--;
                            cashBox[50]--;
                        }
                        else if (cashBox[25] >= 3)
                        {
                            cashBox[25] = cashBox[25] - 3;
                        }
                        else
                        {
                            return no;
                        }

                        break;

                    default:
                        return no;
                }
            }

            return yes;
        }

        //public static string CanAllGetTickets(int[] peopleInLine)
        //{
        //    if (peopleInLine[0] != 25)
        //    {
        //        return "NO";
        //    }

        //    int balance = 0;
        //    foreach (var d in peopleInLine)
        //    {
        //        if (d == 25)
        //        {
        //            balance += 25;
        //        }
        //        else
        //        {
        //            if (balance >= d - 25)
        //            {
        //                balance -= (d - 25);
        //            }
        //            else
        //            {
        //                return "NO";
        //            }
        //        }
        //    }


        //    return "YES";
        //}
    }
}
