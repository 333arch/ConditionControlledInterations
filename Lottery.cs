using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Lottery(int PlayerBall1, int PlayerBall2, int PlayerBall3)
        {
            Random rnd = new Random();
            int Ball1 = 0;
            int Counter1 = 0;
            while (Ball1 != PlayerBall1)
            {
                Ball1 = rnd.Next(31);
                Counter1 = Counter1 + 1;
            }
            int Ball2 = 0;
            int Counter2 = 0;
            while (Ball2 != PlayerBall2)
            {
                Ball2 = rnd.Next(31);
                Counter2 = Counter2 + 1;
            }
            int Ball3 = 0;
            int Counter3 = 0;
            while (Ball3 != PlayerBall3)
            {
                Ball3 = rnd.Next(31);
                Counter3 = Counter3 + 1;
            }
            Console.WriteLine(Ball1 + "took" + Counter1 + "weeks");
            Console.WriteLine(Ball2 + "took" + Counter2 + "weeks");
            Console.WriteLine(Ball3 + "took" + Counter3 + "weeks");
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input a number between 1-30");
            int PlayerBall1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number between 1-30");
            int PlayerBall2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number between 1-30");
            int PlayerBall3 = Convert.ToInt32(Console.ReadLine());
            Lottery(PlayerBall1, PlayerBall2, PlayerBall3);
        }
    }
}
