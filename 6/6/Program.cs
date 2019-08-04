using System;

namespace _6
{
    class Program
    {
        static double squareSumSumSquareDifference(double limit)
        {
            double squareSum = limit * (limit + 1) * (2 * limit + 1) / 6;
            double sumSquare = Math.Pow((limit * (limit + 1) / 2), 2);
            return sumSquare - squareSum;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(squareSumSumSquareDifference(100));
            Console.ReadKey();
        }
    }
}
