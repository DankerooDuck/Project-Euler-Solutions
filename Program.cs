using Project_Euler;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main()
        {
            printInstructions();
            bool loopFlag = true; //loop menu by default
            while(loopFlag == true)
            {

                loopFlag = menu();
            }
        }
        
        public static bool menu()
        {
            Console.WriteLine("\tMain Menu\n");
            listProblems();
            return pickProblem();
        }

        public static bool pickProblem()
        {
            Console.Write("\nEnter the ID of a Problem: ");
            
            string inValue;
            inValue = Console.ReadLine();
            int id = parseInt(inValue);
            Console.Clear();

            switch(id)
            {
                case 0:
                    Console.WriteLine("reached case 0");
                    Console.Clear();
                    return false;
                case 1:
                    problem1.run();
                    Console.Clear();
                    return true;
                case 2:
                    problem2.run();
                    Console.Clear();
                    return true;
                case 3:
                    problem3.run();
                    Console.Clear();
                    return true;
                case 4:
                    problem4.run();
                    Console.Clear();
                    return true;
            }
            Console.WriteLine("\tNo solution found.");
            promptContinue();
            Console.Clear();
            return true;
        }

        public static int parseInt(string inValue)
        {
            int parsedInt = -1;

            try
            {
                int.TryParse(inValue, out parsedInt);
            }
            catch
            {
                throw new FormatException();
                Console.WriteLine("Error Invalid Integer.");
            }

            return parsedInt;
        }

        public static void listProblems()
        {
            Console.Write("ID".PadRight(3) + " |  ".PadLeft(4) + " Problem Description/Title".PadRight(50) + "\n");
            Console.Write("---".PadRight(3) + "-|--".PadLeft(4) + "--------------------------".PadRight(50) + "\n");
            Console.Write("(0)".PadRight(3) + " |  ".PadLeft(4) + " Exit Program".PadRight(50) + "\n");
            Console.Write("(1)".PadRight(3) + " |  ".PadLeft(4) + " Multiples of 3 or 5".PadRight(50) + "\n");
            Console.Write("(2)".PadRight(3) + " |  ".PadLeft(4) + " Even Fibonacci Numbers".PadRight(50) + "\n");
            Console.Write("(3)".PadRight(3) + " |  ".PadLeft(4) + " Largest Prime Factor".PadRight(50) + "\n");
            Console.Write("(4)".PadRight(3) + " |  ".PadLeft(4) + " Largest Palindrome Product".PadRight(50) + "\n");
        }

        public static void promptContinue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void printInstructions()
        {
            Console.WriteLine("\tProject Euler Solutions by DankerooDuck");
            promptContinue();
            Console.Clear();
        }
    }
}