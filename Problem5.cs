using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem5
    {
        public static void description()
        {
            Console.WriteLine("\tProblem 5: Smallest Multiple\n");
            Console.WriteLine("2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.");
            Console.WriteLine("What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?\n");
        }

        public static void solve()
        {
            bool numFound = false;

            int num = 1;
            int result = -1;

            while(numFound == false)
            {
                //Console.WriteLine(num);
                bool evenDiv = evenlyDivisible(num);
                //Console.WriteLine(num + " " + evenDiv);
                if(evenDiv == true)
                {
                    numFound = true;
                    result = num;
                }
                num++;
                /*if(num == 2522)
                {
                    numFound = true;
                }*/
            }


            Console.WriteLine("\n\tSolution:");
            Console.WriteLine("The smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is: " + result);
        }

        public static bool evenlyDivisible(int num)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 20; i > 0; i--)
            {
                int temp = num % i;
                //Console.WriteLine(num + " % " + i + " = " + temp);
                sb.Append(temp);
            }

            //Console.WriteLine(sb.ToString());
            char[] ary = sb.ToString().ToCharArray();

            bool nonZeroFound = false;

            for(int i = 0; i < ary.Length; i++)
            {
                if(ary[i].Equals('0') != true)
                {
                    //Console.WriteLine(ary[i] + "-" + nonZeroFound);
                    nonZeroFound = true;
                }
            }

            if(nonZeroFound == false)
            {
                return true;
            }
            else
            {
                return false;
            }
            

            
            
        }

        public static void run()
        {
            description();
            solve();

            Program.promptContinue();
        }
    }
}
