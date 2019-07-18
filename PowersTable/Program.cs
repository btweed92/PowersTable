using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, it is time to LEARN SQUARES AND CUBES!");

            bool learnMore = true;
            while (learnMore)
            {
                Console.WriteLine("Would you like to do squares and cubes? (y/n)");

                if (Console.ReadLine() == "y")
                {
                    Display(ParseInput());
                }
                else
                {
                    learnMore = false;
                    Console.WriteLine("Too bad, have a good day.");
                }
            }
        }
        public static void Display(int num)
        {
            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("======\t======\t======");
            for(int i=1; i <= num; i++)
            {
                Console.WriteLine($"{i}\t{SquarePower(i)}\t{CubePower(i)}");
            }
        }
        public static int ParseInput()
        {
            Console.WriteLine("Please enter an integer");
            return int.Parse(Console.ReadLine());
        }
        public static int SquarePower(int num)
        {
            return num *= num;
        }
        public static int CubePower(int num)
        {
            return num *= num *= num;
        }
    } 
}
