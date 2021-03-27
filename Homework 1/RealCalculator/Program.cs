using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation would you want to be done ( +, - , * , / )?");
            string mathOperation = Console.ReadLine();
            int result;
            switch(mathOperation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"The result is {result}");
                    break;
                default:
                    Console.WriteLine("Enter valid operation (+, -, *, /)!");
                    break;


            }
            Console.ReadLine();
        }
    }
}
