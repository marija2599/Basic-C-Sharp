using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, spc, rows, k;
            int t = 1;
            Console.Write("Input number of rows : ");
            bool success = int.TryParse(Console.ReadLine(), out rows);
            spc = rows + 4 - 1;
            for (int i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("{0} ",t++);
                Console.Write("\n");
                spc--;
            }
            Console.ReadLine();
        }
    }

}

