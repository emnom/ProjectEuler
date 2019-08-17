using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            while(found == false)
            {
                for(double a = 1; a <= 333; a++)
                {
                    for(double b = a; b < (1000 - a)/2 && b < a*a/2; b++)
                    {
                        double c = Math.Sqrt(a * a + b * b);
                        if (c == Math.Round(c , 0))
                        {
                            if (a + b + c == 1000)
                            {
                                found = true;
                                Console.WriteLine(a * b * c);
                                break;
                            }
                        }
                    }
                    if(found)
                    {
                        break;
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
