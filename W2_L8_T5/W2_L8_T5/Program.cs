using System;

namespace W2_L8_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                double result = Math.Pow(i, 3);
                Console.WriteLine($"{i} do potęgi trzeciej to {result}");
            }
        }
    }
}
