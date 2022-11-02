using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Deprec(double InitPrice, double MiniPrice, int YearBought)
        {
            int YearCounter = 1;
            YearBought = YearBought + YearCounter;
            while (InitPrice > MiniPrice)
            {
                if (YearCounter == 1)
                {
                    InitPrice = InitPrice * 0.7;
                    Console.WriteLine("The price of your car is" + InitPrice + "In the year" + YearBought);
                }
                else
                {
                    InitPrice = InitPrice * 0.8;
                    Console.WriteLine("The price of your car is" + InitPrice + "In the year" + YearBought);
                }
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input the price of your car");
            double InitPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the minimum resale value of your car");
            double MiniPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the year your car");
            int YearBought = Convert.ToInt32(Console.ReadLine());
            Deprec(InitPrice, MiniPrice, YearBought);
        }
    }
}
