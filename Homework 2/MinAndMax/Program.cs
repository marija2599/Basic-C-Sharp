using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6, 1, 2, 20, 8, 9, 4, 12, 16, 3 };
            int min = numbers[0], max = numbers[0];
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                    Console.WriteLine($"The maximum number of the array is: {max}");
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                    Console.WriteLine($"The minimum number of the array is: {min}");
                }
            }
            Console.ReadLine();
        }
    }
}
