using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 3!");
            int number = Convert.ToInt32(Console.ReadLine());
            switch(number)
            {
                case 1: Console.WriteLine("You got a new car!");
                    break;
                case 2: Console.WriteLine("You got a new plane!");
                    break;
                case 3: Console.WriteLine("You got a new bike!");
                    break;
                default: Console.WriteLine("Error please enter number from 1-3!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
