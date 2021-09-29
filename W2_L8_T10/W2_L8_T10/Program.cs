using System;

namespace W2_L8_T10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int nwd;
            int firstNwwNumber = firstNumber;
            int secondNwwNumber = secondNumber;
            int nww;

            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber -= secondNumber;
                }
                else
                {
                    secondNumber -= firstNumber;
                }
            }

            nwd = firstNumber;
            Console.WriteLine($"\nNWD wynosi: {nwd}");
            nww = firstNwwNumber * secondNwwNumber / nwd;
            Console.WriteLine($"\nNWW wynosi: {nww}");
        }
    }
}
