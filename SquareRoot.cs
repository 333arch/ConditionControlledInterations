using System;

namespace ConsoleApp1
{
    class Program
    {
        static void SqRoot(double X)
        {
            Console.WriteLine(X);
            double Root = X;
            while (Root != Math.Sqrt(X))
            {
                Root = 0.5 * (Root + (X / Root));
                Console.WriteLine(Root);
            }
        }
        static void Main(String[] args)
        {
            SqRoot(64);
        }
    }
}
