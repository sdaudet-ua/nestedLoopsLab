using System;

namespace fall_2020_starter_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;
            while (exit == 0)
            {
                int userChoice = ChooseProgram();
                if (userChoice == 1)
                {
                    TriangleProgram();
                    exit = ExitDesired();
                }
                else if (userChoice == 2)
                {
                    GridProgram();
                    exit = ExitDesired();
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Thank you, Goodbye.");
                    exit = 1;
                }
                else
                {
                    Console.WriteLine("Invalid Input, please try again.");

                }
            }

        }
        static int ChooseProgram()
        {
            Console.WriteLine("-Enter 1 to print the triangle displayed in problem 1");
            Console.WriteLine("-Enter 2 to print the numbers table in problem 2");
            Console.WriteLine("-Enter 3 to exit");
            return int.Parse(Console.ReadLine());
        }
        static void TriangleProgram()
        {
            int repeatTimes = 10;
            while (repeatTimes > 0)
            {
                for (int count = 0; count < repeatTimes; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                repeatTimes--;
            }
        }
        static void GridProgram()
        {
            int maxNum = 4;
            for (int count = 1; count <= maxNum; count++)
            {
                 Console.Write($"{count} \t {0*count} \t {1*count} \t {2*count} \t {3*count} \t {4*count} \t {5*count} \t {6*count} \t {7*count} \t {8*count} \t {9*count}\n");
            }
        }
        static int ExitDesired()
        {
            int exit;
            Console.WriteLine("Would you like to run another command? (Y/N)");
            switch (Console.ReadLine())
            {
                case "n":
                exit = 1;
                break;

                case "N":
                exit = 1;
                break;

                default:
                exit = 0;
                break;
            }
            return exit;
        }
    }
}
