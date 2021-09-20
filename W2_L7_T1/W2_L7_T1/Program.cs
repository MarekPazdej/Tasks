using System;

namespace W2_L7_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int number2 = 5;

            if (number == number2)
            {
                Console.WriteLine($"{number} i {number2} są równe");
            }
            else
            {
                Console.WriteLine("Liczby nie są równe.");
            }
        }
    }
}
