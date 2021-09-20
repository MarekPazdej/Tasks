using System;

namespace W2_L7_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber > 0)
            {
                Console.WriteLine($"{userNumber} jest liczbą dodatnią.");
            }
            else
            {
                Console.WriteLine($"{userNumber} jest liczbą ujemną.");
            }
        }
    }
}
