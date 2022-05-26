using System;
namespace Login
{
    internal class program
    {
        public static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int lenght = userName.Length - 1;
            string pass = "";
            for (int i = lenght; i >= 0; i--)
            {
                pass += userName[i];
            }

            int passEntered = 0;
            string password = Console.ReadLine();
            while (password != pass)
            {
                passEntered++;
                if (passEntered > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();

            }
            if (password == pass)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }

    }

}