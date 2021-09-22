using System;

namespace W2_L7_T10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość pierwszego boku trójkąta.");
            byte triangleFirstside = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiego boku trójkąta.");
            byte tringleSecondSide = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Podaj długość trzeciego boku trójkąta.");
            byte triangleThirdSide = Convert.ToByte(Console.ReadLine());

            if (triangleFirstside + tringleSecondSide > triangleThirdSide || triangleThirdSide + triangleThirdSide > triangleFirstside || triangleThirdSide + triangleFirstside > tringleSecondSide)
            {
                Console.WriteLine("Można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta.");
            }
        }
    }
}
