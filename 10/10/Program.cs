using System;
using System.Collections.Generic;

namespace _10
{
    class Program
    {
        static long FindPrimeSum(int limit)
        {
            long current_sum = 2;
            IList<int> primeList = new List<int>{2};
            int current = 3;
            while (current < limit)
            {
                bool isPrime = true;
                foreach (int prime in primeList)
                {
                    if (current % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(current);
                    current_sum += current;
                }
                current+=2;

            }
            return current_sum;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(FindPrimeSum(2000000));
            Console.ReadKey();
        }
    }
}
