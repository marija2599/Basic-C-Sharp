using System;

namespace findTwo3NextToEachOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array");
            bool success = int.TryParse(Console.ReadLine(), out int numberOfElements);
            int[] integersArray = new int[numberOfElements];
            Console.WriteLine($"Enter the {integersArray.Length} numbers");
            int counter = 0;

            for (int i = 0; i < numberOfElements; i++)
            {
                bool secondSuccess = int.TryParse(Console.ReadLine(), out integersArray[i]);
            }
            for (int j = 0; j < integersArray.Length - 1; j++)
            {
                if (integersArray[j] == 3 && integersArray[j + 1] == 3)
                {
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} times where -threes- are next to each other");

            Console.ReadLine();
        }
    }
}
