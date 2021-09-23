using System;

namespace W2_L7_T10
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSideLength = 0;
            bool maxSideA = false;
            bool maxSideB = false;
            bool maxSideC = false;

            Console.WriteLine("Podaj długość pierwszego boku trójkąta.");
            int triangleSideA = Convert.ToInt32(Console.ReadLine());
            maxSideLength = triangleSideA;
            maxSideA = true;

            Console.WriteLine("Podaj długość drugiego boku trójkąta.");
            int triangleSideB = Convert.ToInt32(Console.ReadLine());
            if (triangleSideA < triangleSideB)
            {
                maxSideLength = triangleSideB;
                maxSideB = true;
                maxSideA = false;
            }

            Console.WriteLine("Podaj długość trzeciego boku trójkąta.");
            int triangleSideC = Convert.ToInt32(Console.ReadLine());
            if (triangleSideB < triangleSideC)
            {
                maxSideLength = triangleSideC;
                maxSideC = true;
                maxSideB = false;
            }

            if (maxSideA == true && triangleSideA < triangleSideB + triangleSideC || maxSideB == true && triangleSideB < triangleSideA + triangleSideC || maxSideC == true && triangleSideC < triangleSideA + triangleSideB)
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
