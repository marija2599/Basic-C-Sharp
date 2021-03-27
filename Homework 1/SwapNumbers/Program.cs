using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swaping: first number = {firstNumber}, second number = {secondNumber}");
            int swapNumber;
            swapNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swapNumber;
            Console.WriteLine($"After swaping: first number = {firstNumber}, second number = {secondNumber}");
            Console.ReadLine();
        }
    }
}
