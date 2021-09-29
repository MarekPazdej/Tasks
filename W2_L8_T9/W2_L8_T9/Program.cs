
using System;

namespace W2_L8_T9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFromUser;
            int dividedNumber;
            int restOfDivision;
            string binaryNumber = null;
            string tempBinaryNumber;
            string binaryNumberAfterReverse = null;
            
            Console.WriteLine("Podaj liczbę:\n");
            numberFromUser = Convert.ToInt32(Console.ReadLine());
            dividedNumber = numberFromUser;

            while (dividedNumber > 0)
            {
                restOfDivision =  dividedNumber % 2;
                tempBinaryNumber = Convert.ToString(restOfDivision);
                binaryNumber += tempBinaryNumber;
                dividedNumber = dividedNumber / 2;
            }

            int binNumberLenght = binaryNumber.Length - 1;
            while (binNumberLenght >=0)
            {
                binaryNumberAfterReverse = binaryNumberAfterReverse + binaryNumber[binNumberLenght];
                binNumberLenght--;
            }
            Console.WriteLine($"\nLiczba {numberFromUser} w systemie binarnym to {binaryNumberAfterReverse}");

            
        }
    }
}
