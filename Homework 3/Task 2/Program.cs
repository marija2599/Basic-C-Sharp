using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();
            string[] splited = sentence.Split(" ");
            for(int i = 0; i<splited.Length; i++)
            {
                Console.WriteLine(splited[i]);
            }
            Console.ReadLine();
        }
    }
}
