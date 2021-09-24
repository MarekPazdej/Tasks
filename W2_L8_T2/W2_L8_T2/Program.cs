using System;

namespace W2_L8_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ,");
                }
                i++;
            } while (i <= 1000);
            Console.WriteLine();
        }
    }
}
