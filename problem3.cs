using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class problem3
    {
        public static void description()
        {
            Console.WriteLine("\tProblem 3: Largest Prime Factor\n");
            Console.WriteLine("What is the largest prime factor of the number 600,851,475,143?\n");
            
        }

        public static void solve()
        {
            Int64 number = 600851475143;
            int lastDivisor = 0;
            Int64 quotient = number;

            while (quotient % 2 == 0)
            {
                lastDivisor = 2;
                quotient = quotient / 2;
            }

            int divisor = 3;
            while (quotient > 1)
            {
                while(quotient % divisor == 0)
                {
                    quotient = quotient / divisor;
                    lastDivisor = divisor;
                }
                divisor = divisor + 2;
            }

            Console.WriteLine("\n\tSolution:");
            Console.WriteLine("The largest prime factor of the number 660,851,475,143 is: " + lastDivisor);
        }

        public static void run()
        {
            description();
            solve();
            Program.promptContinue();
        }
    }
}
