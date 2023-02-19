using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem6
    {
        public static void description()
        {
            Console.WriteLine("\tProblem 6: Sum Square Difference\n");
            Console.WriteLine("The sum of the squares of the first ten natural numbers is,");
            Console.WriteLine("\t1^2 + 2^2 ... + 10^2 = 385");
            Console.WriteLine("The square of the sum of the first ten natural numbers is,");
            Console.WriteLine("\t(1 + 2 + ... + 10)^2 = 55^2 = 3025");
            Console.WriteLine("Hence the difference between the sum of the squares of the");
            Console.WriteLine("first ten natural numbers and the square of the sum is: 3025 - 385 = 2640");
            Console.WriteLine("Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.\n");
        }

        public static void solve()
        {
            double sumOfSqrs = 0;
            double sum = 0;
            double sqOfSum = 0;
            double difference = 0.0;

            //calc sum of the squares
            for (int i = 1; i <= 100; i++)
            {
                double sqrd = Math.Pow(i, 2);
               //Console.WriteLine(i + " sqrd = " + sqrd);
                sumOfSqrs += sqrd;
                //Console.WriteLine("sum = " + sumOfSqrs);
            }

            //calc sum
            for(int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            //square sum
            sqOfSum = Math.Pow(sum, 2);
            difference = sqOfSum - sumOfSqrs;

            //Console.WriteLine("Sum of the Squares = " + sumOfSqrs);
            //Console.WriteLine("Square of the Sum = " + Math.Pow(sum, 2));



            Console.WriteLine("\n\tSolution:");
            Console.WriteLine("The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is: " + difference);
        }



        public static void run()
        {
            description();
            solve();

            Program.promptContinue();
        }
    }
}
