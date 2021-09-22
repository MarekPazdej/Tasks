using System;

namespace W2_L7_T8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sumOfResults = 0;

            Console.WriteLine("Podaj wynik z matematyki:");
            byte mathsResult = Convert.ToByte(Console.ReadLine());
            sumOfResults = mathsResult;

            Console.WriteLine("Podaj Wynik z fizyki:");
            byte physicsResult = Convert.ToByte(Console.ReadLine());
            sumOfResults += physicsResult;

            Console.WriteLine("Podaj wynik z chemi:");
            byte chemistryResult = Convert.ToByte(Console.ReadLine());
            sumOfResults += chemistryResult;

            Console.WriteLine(sumOfResults);

            if ((mathsResult >= 70 && physicsResult >= 45 && chemistryResult >= 45 && sumOfResults >= 180) || mathsResult + physicsResult >= 150 || mathsResult + chemistryResult >= 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");
            }
        }
    }
}
