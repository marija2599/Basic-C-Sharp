using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool firstNumberParsed = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number: ");
            bool secondNumberParsed = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("What operation would you want to be done? ( +, - , * , / )");
            string mathOperation = Console.ReadLine();
            int result;
            switch(mathOperation)
            {
                case "+": result = num1 + num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "-": result = num1 - num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "*": result = num1 * num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "/": result = num1 / num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                default:
                    Console.WriteLine("Error! Enter valid operation!");
                    break;
          
            }
            Console.ReadLine();

        }
    }
}
