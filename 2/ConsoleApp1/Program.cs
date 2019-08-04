using System;

namespace ConsoleApp1
{
    class Program
    {
        static int EvenFibo(int limit)
        {
            int Fibo1 = 1;
            int Fibo2 = 2;
            int EvenSum = 2;
            while (Fibo2 <= limit)
            {
                Fibo2 += Fibo1;
                Fibo1 = Fibo2 - Fibo1;
                if (Fibo2 % 2 == 0)
                {
                    EvenSum += Fibo2;
                }
            }
            return EvenSum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(EvenFibo(4000000));
            Console.ReadKey();
        }
    }
}
