using System;

namespace W2_L7_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int userHeight = Convert.ToInt32(Console.ReadLine());

            if (userHeight < 140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (userHeight >= 140 && userHeight < 150)
            {
                Console.WriteLine("Witaj niziołku");
            }
            else if (userHeight >= 150 && userHeight < 160)
            {
                Console.WriteLine("Prawdziwy z ciebie elf");
            }
            else if (userHeight >= 160 && userHeight < 170)
            {
                Console.WriteLine("Jeszcze musisz używać stołeczka.");
            }
            else if (userHeight >= 170 && userHeight < 180)
            {
                Console.WriteLine("Wyrosłeś :)");
            }
            else if (userHeight >= 180 && userHeight < 190)
            {
                Console.WriteLine("Ale z ciebie tyczka.");
            }
            else if (userHeight >= 190 && userHeight < 200)
            {
                Console.WriteLine("Jesteś wielkoludem.");
            }
            else if (userHeight >= 2000)
            {
                Console.WriteLine("Gigant z ciebie.");
            }
        }
    }
}
