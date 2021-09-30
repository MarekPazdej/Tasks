using System;

namespace W2_L8_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            float convertedFraction;
            float sumOfFraction = 0;
            float denominator = 0;

            for (int i = 1; i <= 20; i++)
            {
                denominator++;
                convertedFraction = 1f / denominator;
                sumOfFraction += convertedFraction;
            }
            Console.WriteLine($"Suma ułamków wynosi {sumOfFraction:F4}");
        }
    }
}
