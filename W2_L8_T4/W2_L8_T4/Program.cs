using System;

namespace W2_L8_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            Console.WriteLine();
            for (int i = 1; i < userNumber; i++)
            {
                if (counter <= userNumber)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (counter <= userNumber)
                        {
                            Console.Write(counter + " ");
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}
