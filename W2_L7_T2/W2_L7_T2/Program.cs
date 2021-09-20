using System;

namespace W2_L7_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number.");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"{userNumber} jest liczbą parzystą.");
            }
            else
            {
                Console.WriteLine($"{userNumber} nie jest parzystą.");
            }
        }
    }
}
