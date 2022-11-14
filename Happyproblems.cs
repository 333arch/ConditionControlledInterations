using System;

namespace ConsoleApp1
{
    class Program
    {
        static string Happy(int Number)
        {
            bool Complete = false;
            string IsHappy = "";
            string NString;
            int IDigit;
            int Total;

            while (!Complete)
            {
                NString = Convert.ToString(Number);
                Total = 0;
                for (int Digit = 0; Digit < NString.Length; Digit++)
                {
                    IDigit = Convert.ToInt32(Convert.ToString(NString[Digit]));
                    if (IDigit == 4)
                    {
                        Complete = true;
                        IsHappy = "Sad";
                    }
                    Total += (IDigit * IDigit);
                }
                Number = Total;
                if (Number == 1)
                {
                    Complete = true;
                    IsHappy = "Happy";
                }
            }
            return IsHappy;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Happy(Number));
        }
    }
}
