using System;
using System.Collections.Generic;

namespace _12
{
    class Program
    {
        static int firstTrianNumOverXDivisor(int limit)
        {
            int currentNum = 1;
            int triNum;
            int curDiv ;
            IDictionary<int, int> divisors = new Dictionary<int, int>();
            while(true)
            {
                curDiv = 3;
                triNum = currentNum * (currentNum + 1) / 2;
                divisors.Clear();
                triNum = Calculate(triNum, divisors, 2);
                while (triNum > 1)
                {
                    triNum = Calculate(triNum, divisors, curDiv);
                }
                int divs = 1;
                foreach (int power in divisors.Values)
                {
                    divs *= (power + 1);
                }
                if (divs > limit)
                {
                    break;
                }
                currentNum++;
            }
            return (currentNum * (currentNum + 1) / 2);
        }

        private static int Calculate(int triNum, IDictionary<int, int> divisors, int divisor)
        {
            while (triNum % divisor == 0)
            {
                triNum /= divisor;
                if (divisors.ContainsKey(divisor))
                {
                    divisors[divisor]++;
                }
                else
                {
                    divisors.Add(divisor, 1);
                }
            }

            return triNum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(firstTrianNumOverXDivisor(500));
            Console.ReadKey();
        }
    }
}
