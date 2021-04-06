using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            int i, l;
            string str = "";
            l = input.Length - 1;
            for(i=l;i>=0;i--)
            {
                str = str + input[i];
            }
            Console.WriteLine("The string in reverse order is : \n********{0}********", str);
            Console.ReadLine();
        }
    }
}
