using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter second number: ");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int num2);
            int swapNum;
            Console.WriteLine($"Before swaping: first number: {num1}, second number: {num2}");
            swapNum = num1;
            num1 = num2;
            num2 = swapNum;
            Console.WriteLine($"After swaping: first number: {num1}, second number: {num2}");
            Console.ReadLine();
        }
    }
}
