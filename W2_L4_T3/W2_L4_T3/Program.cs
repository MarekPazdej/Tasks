using System;

namespace W2_L4_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            string userImput = Console.ReadLine();
            int rectangleLenght;
            bool isNumber = int.TryParse(userImput, out rectangleLenght);

            Console.WriteLine("Enter the width of the rectangle: ");
            string userImput1 = Console.ReadLine();
            int rectangleWidth;
            bool isNumber1 = int.TryParse(userImput1, out rectangleWidth);

            double diagonal = Math.Sqrt(Math.Pow(rectangleWidth, 2) + Math.Pow(rectangleLenght, 2));

            Console.WriteLine($"Lenght of diagonal is: {diagonal}");

        }
    }
}
