using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());
            int average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {average}");
            Console.ReadLine();

        }
    }
}
