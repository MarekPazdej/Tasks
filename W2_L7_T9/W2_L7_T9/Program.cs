using System;

namespace W2_L7_T9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj obecną temperaturę na zewnątrz.");
            int tempOutSide = Convert.ToByte(Console.ReadLine());

            if (tempOutSide < 0)
            {
                Console.WriteLine("Cholernie piździ.");
            }
            else if (tempOutSide >= 0 && tempOutSide < 10)
            {
                Console.WriteLine("Zimno.");
            }
            else if (tempOutSide >= 10 && tempOutSide < 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (tempOutSide >= 20 && tempOutSide < 30)
            {
                Console.WriteLine("W sam raz.");
            }
            else if (tempOutSide >= 30 && tempOutSide < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco.");
            }
            else if (tempOutSide >= 40)
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę.");
            }
        }
    }
}
