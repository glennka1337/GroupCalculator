﻿namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static int Division(int userInput1, int userInput2)
        {
            int sum = userInput1 / userInput2;
            Console.WriteLine($"Svaret är: {sum}");
            return sum;
        }
    }
}
