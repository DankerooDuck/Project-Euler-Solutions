using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem4
    {
        public static void description()
        {
            Console.WriteLine("\tProblem 4: Largest Palindrome Product\n");
            Console.WriteLine("A palindromic number reads the same both ways.");
            Console.WriteLine("The largest palindrome made from the product of two 2-digit numbers is: \n");
            Console.WriteLine("\t9009 = 91 x 99\n");
            Console.WriteLine("Find the largest palindrome made from the product of two 3-digit numbers.\n");
        }

        public static void solve()
        {
            long largestNumber = 0;
            
            for(int i = 100; i < 1000; i++)
            {
                for(int j = 1000; j > 100; j--)
                {
                    long temp = i * j;
                    bool palinFlag = isPalindrome(temp);
                    if(palinFlag == true)
                    {
                        //Console.WriteLine(i + " * " + j + " = " + temp);
                        if (temp > largestNumber)
                        {
                            largestNumber = temp;
                            //Console.WriteLine("Set Largest Number as: " + largestNumber);
                        }
  
                    }
                        
                    
                }
            }
            Console.WriteLine("\n\tSolution:");
            Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers is: " + largestNumber);
        }

        public static bool isPalindrome(long number)
        {
            string num = number.ToString();
            int start = 0;
            int end = num.Length - 1;
            while(start < end)
            {
                if (num[start++] != num[end--])
                {
                    return false;
                }
            }
            return true;
        }

        public static void run()
        {
            description();
            solve();

            //long num = 8008;
            //Console.WriteLine("Is " + num + " a palindrome?" + isPalindrome(num));

            Program.promptContinue();
        }
    }
}
