using System;
using System.Globalization;
namespace Vacation
{
    internal class program
    {
        public static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = people * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = people * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = people * 10.46;
                }
                if (people >= 30)
                {
                    price -= price * 0.15;
                }
                
            }
            if (groupType == "Business")
            {

                if (dayOfWeek == "Friday")
                {
                    price = people * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = people * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = people * 16;
                }
                if (people >= 100)
                {
                    price -= price / people * 10;
                }
            }   
            if (groupType == "Regular")
            {

                if (dayOfWeek == "Friday")
                {
                    price = people * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = people * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = people * 22.50;
                }
                if (people >= 10 && people <= 20)
                {
                    price -= price * 0.05;
                }

            }
            Console.WriteLine($"Total price: {price:f2}");
            
        }

    }

}