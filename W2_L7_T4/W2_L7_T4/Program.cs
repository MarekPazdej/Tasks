using System;

namespace W2_L7_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok do sprawdzenia.");

            int yearToCheck = Convert.ToInt32(Console.ReadLine());

            if((yearToCheck % 4 == 0 && yearToCheck % 100 != 0) || yearToCheck % 400 == 0)
            {
                Console.WriteLine($"{yearToCheck} jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine($"{yearToCheck} nie jest rokiem przestępnym.");
            }
        }
    }
}
