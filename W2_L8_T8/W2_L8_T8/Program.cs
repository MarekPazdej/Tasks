using System;

namespace W2_L8_T8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj przykładowy tekst:");
            string userInput = Console.ReadLine();
            string reversUserInput = "";
            int stringLenght;

            stringLenght = userInput.Length -1;

            while (stringLenght >= 0)
            {
                reversUserInput = reversUserInput + userInput[stringLenght];
                stringLenght--;
            }
            Console.WriteLine(reversUserInput);
        }
    }
}
