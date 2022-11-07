using System;

namespace ConsoleApp1
{
    class Program
    {
        static void ATM(int Money)
        {
            while (Money > 0)
            {
                int Twenties = Money / 20;
                Console.WriteLine(Twenties);
                Money = Money - (Twenties * 20);
                int Tens = Money / 10;
                Console.WriteLine(Tens);
                Money = Money - (Tens * 10);
                int Fives = Money / 5;
                Console.WriteLine(Fives);
                Money = Money - (Fives * 5);
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input the amount of money");
            int Money = Convert.ToInt32(Console.ReadLine());
            ATM(Money);
        }
    }
}
