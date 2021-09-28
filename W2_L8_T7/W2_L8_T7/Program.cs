using System;

namespace W2_L8_T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku diamentu: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            char whiteSpaces = ' ';
            char printedSings = '*';
            int rows = 0;
            int columns = 0;
            int spaces = 0;

            while (rows<userNumber)
            {
                for (columns = 0; columns < userNumber - spaces; columns++)
                {
                    Console.Write(whiteSpaces);
                }
                for (columns = 0; columns <= rows+spaces; columns++)
                {
                    Console.Write(printedSings);
                }
                Console.WriteLine();
                rows++;
                spaces++;
            }


            rows--;
            spaces--;
            while (rows >= 0)
            {
                for (columns = 0; columns <= userNumber - spaces; columns++)
                {
                    Console.Write(whiteSpaces);
                }
                for (columns = 0; columns < (rows+spaces)-1; columns++)
                {
                    Console.Write(printedSings);
                }
                Console.WriteLine();
                rows--;
                spaces--;
            }

        }
    }
}
