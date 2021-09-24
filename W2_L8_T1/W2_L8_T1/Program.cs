using System;

namespace W2_L8_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                if ((i % 2 == 0 && i / 2 == 1) || (i % 3 == 0 && i / 3 == 1) || (i % 5 == 0 && i / 5 == 1) || (i % 7 == 0 && i / 7 == 1))
                {
                    Console.Write(i + " ,");
                }
                else if (i % 2 >= 1 && i % 3 >= 1 && i % 5 >= 1 && i % 7 >= 1)
                {
                    Console.Write(i + " ,");
                }
            }
        }
    }
}
