using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6];
            int sumOFEven = 0;
                Console.WriteLine("Enter first number: ");
                bool success1 = int.TryParse(Console.ReadLine(), out intArray[0]);
                Console.WriteLine("Enter second number: ");
                bool success2 = int.TryParse(Console.ReadLine(), out intArray[1]);
                Console.WriteLine("Enter third number: ");
                bool success3 = int.TryParse(Console.ReadLine(), out intArray[2]);
                Console.WriteLine("Enter fourth number: ");
                bool success4 = int.TryParse(Console.ReadLine(), out intArray[3]);
                Console.WriteLine("Enter fifth number: ");
                bool success5 = int.TryParse(Console.ReadLine(), out intArray[4]);
                Console.WriteLine("Enter sixth number: ");
                bool success6 = int.TryParse(Console.ReadLine(), out intArray[5]);

            for(int i =0; i< intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sumOFEven += intArray[i];
                }
            }
            Console.WriteLine($"The sum of the even numbers is: {sumOFEven}");
            Console.ReadLine();
            

        }
    }
}
