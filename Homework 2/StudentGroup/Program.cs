using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Andrej", "Ana", "Kate", "Stojan", "Kole" };
            string[] studentsG2 = { "Eli", "Milan", "Tea", "Matej", "Bojan" };
            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            bool success = int.TryParse(Console.ReadLine(), out int numberInput);
            if(numberInput == 1)
            {
                Console.WriteLine("The students in G1 group are: ");
                foreach (string students in studentsG1)
                {
                    Console.WriteLine(students);
                }
            }
            else if(numberInput == 2)
            {
                Console.WriteLine("The students in G2 group are: ");
                foreach (string students in studentsG2)
                {
                    Console.WriteLine(students);
                }
            }
            else
            {
                Console.WriteLine("Error! Please enter number 1 or 2!");
            }
            
            Console.ReadLine();
        }
    }
}
