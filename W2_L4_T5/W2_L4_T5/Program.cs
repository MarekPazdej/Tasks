using System;

namespace W2_L4_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string phoneNumber;
            string email;
            int growth;
            double weight;
            char gender;
            string hairColor;
            
            Console.WriteLine("Please enter your personal details.\n");

            Console.WriteLine("Your name?");
            name = Console.ReadLine();

            Console.WriteLine("Surname:");
            surname = Console.ReadLine();

            Console.WriteLine("Phone number:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("E-mail:");
            email = Console.ReadLine();

            Console.WriteLine("Growth:");
            growth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Weight:");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gender (W)/(M)");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Hair color:");
            hairColor = Console.ReadLine();

            Console.WriteLine($"\nName: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Phone number: {phoneNumber}");
            Console.WriteLine($"E-mail: {email}");
            Console.WriteLine($"Growth: {growth}");
            Console.WriteLine($"weight {weight}");
            Console.WriteLine($"Hair color: {hairColor}");
            
        }
    }
}
