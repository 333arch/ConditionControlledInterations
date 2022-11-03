using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Offer()
        {
            int number = 10;
            while (number < 60)
            {
                Random rnd = new Random();
                int num = rnd.Next(20);
                number += num;
                Console.WriteLine(number);
            }
        }
        static void Main(String[] args)
        {
            Offer();
        }
    }
}
