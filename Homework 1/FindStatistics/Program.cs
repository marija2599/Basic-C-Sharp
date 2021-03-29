using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter second number: ");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int secondNumber);
            int result;
            if (firstNumber % 2 == 0 & secondNumber % 2 == 0)
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"Both of the numbers you entered are 'even'. The operation and result are {firstNumber} + {secondNumber} = {result}");
            }
            if (firstNumber % 2 != 0 ^ secondNumber % 2 != 0)
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"One of the numbers you entered is 'odd'. The operation and result are {firstNumber} - {secondNumber} = {result}");
            }
            if (firstNumber % 2 != 0 & secondNumber % 2 != 0)
            {
                result = firstNumber * secondNumber;
                Console.WriteLine($"Both of the numbers you entered are 'odd'. The operation and result are {firstNumber} * {secondNumber} = {result}");
            }
            Console.ReadLine();
        }
    }

}
