using System;

namespace W2_L7_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Popdaj swój wiek.");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >=35)
            {
                Console.WriteLine($"Mając {userAge} możesz zostać posłem, premierem, senatorem a nawet prezydentem.");
            }
            else if (userAge >= 30 && userAge < 35)
            {
                Console.WriteLine($"Mając {userAge} możesz sostać posłem, premierem, senatorem.");
            }
            else if (userAge >=21 && userAge < 30)
            {
                Console.WriteLine($"Mając {userAge} możesz zostać posłem, premierem.");
            }
            else
            {
                Console.WriteLine("Musisz jeszcze poczekać na \"wielką\" politykę.");
            }
        }
    }
}
