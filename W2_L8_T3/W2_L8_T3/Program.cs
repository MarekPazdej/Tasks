using System;

namespace W2_L8_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibA = 0;
            int fibB = 1;
            int fibVolume = 0;

            Console.WriteLine(fibA);
            Console.WriteLine(fibB);
            do
            {
                fibVolume = fibA + fibB;
                Console.WriteLine(fibVolume);
                fibA = fibB;
                fibB = fibVolume;
            } while (fibVolume <= 1000000);
        }
    }
}
