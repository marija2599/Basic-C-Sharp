using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday: ");
            bool success = DateTime.TryParse(Console.ReadLine(), out DateTime birthdateDate);
            if (success)
            {
                AgeCalculator(birthdateDate);
            }
            else
            {
                Console.WriteLine("Error, please enter a valid birth date!");
            }

            Console.ReadLine();
        }
        static void  AgeCalculator(DateTime myBirthdayDate)
        {
            int Days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (myBirthdayDate.Year * 365 + myBirthdayDate.DayOfYear);
            int Years = Days / 365;
            Console.WriteLine($"You have: {Years} years.");

        }

    }
}
