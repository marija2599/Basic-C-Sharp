using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            bool success = int.TryParse(Console.ReadLine(), out int number);
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;

            }
            Console.WriteLine($"The sum of the digits of your number is: {sum}");
            Console.ReadLine();
       
        }
    }
}
