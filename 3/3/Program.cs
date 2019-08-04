using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static int MaxPrimeFactor(long num)
        {

            int CurrentFactor = 2;
            IList<int> Primes = new List<int>();
            while(CurrentFactor <= num)
            {
                bool NotPrime = false;
                foreach (int prime in Primes)
                {
                    if(CurrentFactor % prime == 0)
                    {
                        NotPrime = true;
                        break;
                    }
                }
                if(NotPrime == false)
                {
                    Primes.Add(CurrentFactor);
                    while(num % Primes[Primes.Count -1] == 0)
                    {
                        num /= Primes[Primes.Count - 1];
                    }
                }
                if(num == 1)
                {
                    break;
                }
                CurrentFactor += 1;
            }
            return CurrentFactor;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(MaxPrimeFactor(600851475143));
            Console.ReadKey();
        }
    }
}


