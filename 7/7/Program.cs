using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Program
    {
        static int FindPrime(int limit)
        {
            IList<int> primeList = new List<int>();
            int current = 2;
            while(primeList.Count < limit)
            {
                bool isPrime = true;
                foreach(int prime in primeList)
                {
                    if(current % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    primeList.Add(current);
                }
                current++;

            }
            return primeList[primeList.Count - 1];
        }



        static void Main(string[] args)
        {
            Console.WriteLine(FindPrime(10001));
            Console.ReadKey();
        }
    }
}
