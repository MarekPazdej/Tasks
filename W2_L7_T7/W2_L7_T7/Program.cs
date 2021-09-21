using System;

namespace W2_L7_T7
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;

            Console.WriteLine("Podaj pierwszą liczbę:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if ((firstNumber < secondNumber) && (thirdNumber < secondNumber))
            {
                maxNumber = secondNumber;
            }
            else if ((secondNumber < thirdNumber) && (firstNumber < thirdNumber))
            {
                maxNumber = thirdNumber;
            }
            else
            {
                maxNumber = firstNumber;
            }

            Console.WriteLine($"{maxNumber} jest największą liczbą");
        }
    }
}
