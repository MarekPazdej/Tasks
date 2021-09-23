using System;

namespace W2_L7_T11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ocenę w postaci liczby.");
            sbyte rating = Convert.ToSByte(Console.ReadLine());

            switch (rating)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("To nie jest ocena.");
                    break;
            }
        }
    }
}
