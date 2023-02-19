using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Project_Euler
{
    internal class Problem1
    {
        public static void description()
        {
            Console.WriteLine("\tProblem 1: Multiples of 3 or 5\n");
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.");
            Console.WriteLine("The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.\n");
        }

        public static void solve()
        {
            int result = 0;

            for(int i = 0; i < 1000; i++)
            {
                if((i % 3) == 0 || (i % 5) == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine("\n\tSolution:");
            Console.WriteLine("The sum of all multiples of 3 or 5 below 1000 is: " + result);
        }

        public static void run()
        {
            description();
            solve();
            Program.promptContinue();
        }
    }
}
