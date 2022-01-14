using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            PrintThrees();

            Console.WriteLine("Please enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter it again:");
            int b = int.Parse(Console.ReadLine());
            IsEqual(a, b);

            Console.WriteLine("Now enter a different number, this time only once. I will then check if it is even or odd:");
            int c = int.Parse(Console.ReadLine());
            EvenOrOdd(c);

            Console.WriteLine("Next, give me yet another number and I will check if it is positive or negative. Don't enter zero:");
            int d = int.Parse(Console.ReadLine());
            PosOrNeg(d);

            Console.WriteLine("I will now determine your voting eligibility. Please enter your age... don't enter zero.. :");
            int age = int.Parse(Console.ReadLine());
            VotingAge(age);

            Console.WriteLine("Enter a number between 10 and -10. Zero is acceptable here :) :");
            int e = int.Parse(Console.ReadLine());
            RangeCheck(e);

            Console.WriteLine("Finally, give me one last number and I will show you its multiplication table from 1 to 12:");
            int f = int.Parse(Console.ReadLine());
            MultiplicationTables(f);

            Console.WriteLine("Thanks for your time.");
           
        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintThrees()
        {
            for (int j = 3; j <= 999; j += 3)
            {
                Console.WriteLine(j);
            }
        }

        public static void IsEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Those numbers are equal.");
            }
            else
            {
                Console.WriteLine("Those numbers are not equal...");
            }
        }

        public static void EvenOrOdd(int c)
        {
            if (c % 2 == 0)
            {
                Console.WriteLine("That's even.");
            }
            else
            {
                Console.WriteLine("That's odd.");
            }
        }

        public static void PosOrNeg(int d)
        {
            if (d > 0)
            {
                Console.WriteLine("That number is positive.");
            }
            else if (d < 0)
            {
                Console.WriteLine("That number is negative.");
            }
            else
            {
                Console.WriteLine("You entered a zero...");
            }
        }

        public static void VotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You may vote as long as you are registered.");

            }
            else
            {
                Console.WriteLine($"You cannot yet cast your vote, however in {18 - age} years you may register to do so.");
            }
        }

        public static void RangeCheck(int e)
        {
            if (e >= -10 && e <= 10)
            {
                Console.WriteLine("That number is within range.");
            }
            else
            {
                Console.WriteLine("That number is out of range.");
            }
        }

        public static void MultiplicationTables(int f)
        {
            for (int k = 1; k <= 12; k++)
            {
                Console.WriteLine(f * k);
            }
        }
    }
}

