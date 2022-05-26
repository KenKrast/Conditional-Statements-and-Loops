using System;
namespace Print_and_Sum
{
    internal class program
    {
        public static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num1 <= num2)
            {
                Console.Write(num1 +" ");
                sum += num1;
                num1++;
               
            }
           Console.WriteLine("\nSum: " + sum);
        }    

    }

}