using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool firstNumberParsed = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number: ");
            bool secondNumberParsed = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter the first number: ");
            bool thirdNumberParsed = int.TryParse(Console.ReadLine(), out int num3);
            Console.WriteLine("Enter the second number: ");
            bool fourthNumberParsed = int.TryParse(Console.ReadLine(), out int num4);
            int average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {average}");
            Console.ReadLine();

        }
    }
}
