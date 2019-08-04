using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static int GCDToNumber(int limit)
        {
            int answer = 1;
            IDictionary<int, int> primePower = new Dictionary<int, int>();
            int currentNum = 2;
            while(currentNum <= limit)
            {
                int usedNum = currentNum;
                foreach (KeyValuePair<int, int> prime in primePower)
                {
                    for(int num = 0; num < prime.Value; num++)
                    {
                        if(usedNum % prime.Key == 0)
                        {
                            usedNum /= prime.Key;
                        }
                    
                    }
                    if(usedNum == 1 )
                    {
                        break;
                    }
                    if(usedNum % prime.Key == 0)
                    {
                        usedNum = 1;
                        primePower[prime.Key] += 1;
                        answer *= prime.Key;
                        break;
                    }
                }
                if(usedNum != 1)
                {
                    answer *= usedNum;
                    primePower.Add(usedNum, 1);
                }
                currentNum += 1;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GCDToNumber(20));
            Console.ReadKey();
        }
    }
}
