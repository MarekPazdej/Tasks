using System;

namespace W2_L7_T13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosty kalkulator\n");

            Console.WriteLine("Podaj pierwszą liczbę:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Podaj drugą liczbę:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("\nPodaj numer operacji do wykonania:\n");
            Console.WriteLine("\t1. Dodawanie");
            Console.WriteLine("\t2. Odejmowanie");
            Console.WriteLine("\t3. Mnożenie");
            Console.WriteLine("\t4. Dzielenie");

            sbyte userChoice = Convert.ToSByte(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine($"\nTwój wynik to: " + (firstNumber + secondNumber));
                    break;
                case 2:
                    Console.WriteLine("\ntwój wynik to: " + (firstNumber - secondNumber));
                    break;
                case 3:
                    Console.WriteLine("\nTwój wynik to: " + (firstNumber * secondNumber));
                    break;
                case 4:
                    if (secondNumber != 0)
                    {
                        Console.WriteLine("\nTwój wynik to: " + (firstNumber / secondNumber));
                    }
                    else
                    {
                        Console.WriteLine("\nPamiętaj... nie dziel przez ZERO.");
                    }
                    break;
                default:
                    Console.WriteLine("\nNie ma takiej opcji.");
                    break;
            }
        }
    }
}
