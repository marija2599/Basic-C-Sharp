using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 1-3!");
            bool parsedResult = int.TryParse(Console.ReadLine(), out int number);
            switch(number)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Error enter number from 1 to 3!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
