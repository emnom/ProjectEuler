using System;

namespace _4
{
    class Program
    {
        static int LargestPalindromeProduct(int limit)
        {
            int largestProduct = 1;
            for(int num1 = 1; num1 <= limit; num1++)
            {
                for(int num2 = 1; num2 <= num1; num2++)
                {
                    string stringProduct = (num1 * num2).ToString();
                    int iterator = 0;
                    bool isPalindrome = true;
                    int len = stringProduct.Length;
                    while (iterator < len/2)
                    {
                        if(stringProduct[iterator] != stringProduct[len - iterator - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                        iterator ++;
                    }
                    if(isPalindrome & num1 * num2 > largestProduct)
                    {
                        largestProduct = num1 * num2;
                    }
                }
            }
            return largestProduct;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(LargestPalindromeProduct(999));
            Console.ReadKey();
        }
    }
}
