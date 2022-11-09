using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Converter(int Den)
        {
            string BinNumber = "";
            while (Den > 0)
            {
                int Remain = (Den % 2);
                Den = Den / 2;
                BinNumber = Convert.ToString(Remain) + BinNumber;
                Console.WriteLine(BinNumber);
            }
        }
        static void Main(String[] args)
        {
            Converter(26);
        }
    }
}
