using System;
using System.Threading;

namespace _05.Condition.Operators.Pertormance
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong result1 = Sum(5);
            Console.WriteLine($"Total from 1 to n is {result1}");
            ulong result2 = Sum2(5);
            Console.WriteLine($"Total from 1 to n is {result2}");

            ulong n = 10_000UL;
            Console.WriteLine($"Total from 1 to n is {Sum(n)}");
            ulong result3 = SumWithPerformance(2);
            Console.WriteLine($"Total from 1 to n is {result3}");

            if (n < 10 && SumWithPerformance(n) > 1000)
                Console.WriteLine("Program condition is successfully");
            else
                Console.WriteLine("Program condition is failure");
            if (n < 10 & SumWithPerformance(n) > 1000)
                Console.WriteLine("Program condition is successfully");
            else
                Console.WriteLine("Program condition is failure");
            Console.WriteLine("Hello World!");
        }
        static ulong Sum(ulong n)
        {
            ulong sum = 0;
            for (ulong i = 0; i <= n ; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        //Body Expression
        static ulong Sum2(ulong n) => n * (n + 1) / 2;

        static ulong SumWithPerformance(ulong n)
        {
            ulong sum = 0;
            for (ulong i = 0; i <= n; i++)
            {
                sum += i;// sum = sum + i
                Thread.Sleep(1); //1s = 1000ms
                Console.Write(".");
            }
            return sum;
        }
    }
}
