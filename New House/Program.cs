using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(args[0]);
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double money = 0;

            switch (season)
            {
                case "Spring":
                    money = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    money = 4200;
                    break;
                case "Winter":
                    money = 2600;
                    break;
                default:
                    break;
            }
            if (fisherman <= 6)
            {
                money = money * 10 / 100;
            }
            else if (fisherman <= 11)
            {
                money = money = 15 / 100;
            }
            else
            {
                money = money = 25 / 100;
            }

            if (fisherman % 2 == 0 && season != "Autumn")
            {
                money = money - 5 / 100;
            }
            if (money >= budget)
            {
                Console.WriteLine($"Yes! You have {budget - money:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {money - budget:f2} leva.");
            }


        }
    }
}