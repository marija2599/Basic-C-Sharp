using System;

namespace Task_4
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
       
        static void Calculator(string operation, int num1, int num2)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"The sum is: {Sum(num1, num2)}");
                    break;
                case "-":
                    Console.WriteLine($"The difference is: {Substract(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"The multiplication is: {Multiplication(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine($"The divison is: {Division(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool success1 = int.TryParse(Console.ReadLine(), out int number1);
            Console.WriteLine("Enter the second number: ");
            bool success2 = int.TryParse(Console.ReadLine(), out int number2);
            Console.WriteLine("Enter the operation (+, -, *, /)");
            string operation = Console.ReadLine();
            if (success1 & success2)
            {
                Calculator(operation, number1, number2);
            }
            else
            {
                Console.WriteLine("Error, can not parsed the numbers!");
            }
            Console.ReadLine();
        }

        
    }
    
}

