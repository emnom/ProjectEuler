using System;

namespace ConsoleApp1
{
    class Program
    {
        static int ThreeOrFive(int num)
        {
            int sum = 0;
            for (int current = 1; current < num; current++)
            {
                if (current % 3 == 0)
                {
                    sum += current;
                }
                else
                {
                    if (current % 5 == 0)
                    {
                        sum += current;
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeOrFive(1000));
            Console.ReadKey();
        }
    }
}
