using System;
using System.Threading;

namespace _05.Condition.Operators.Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong result1 = Sum(10);
            Console.WriteLine($"Total from 1 to 10 is {result1}");

            ulong result2 = Sum(20);
            Console.WriteLine($"Total from 1 to 20 is {result2}");

            ulong result3 = Sum2(10);
            Console.WriteLine($"Total from 1 to 10 is {result3}");

            ulong result4 = Sum2(20);
            Console.WriteLine($"Total from 1 to 10 is {result4}");

            ulong n = 10_000UL;
            Console.WriteLine($"Total from 1 to 10_000 is {Sum2(n)}");

            if(n < 10 && SumWithPerformance(n) > 1000)//Good Performance
                Console.WriteLine("Program runs successfully");
            else
                Console.WriteLine("Program condition is failure");

            if(n < 10 & SumWithPerformance(n) > 1000) //Bad Performance
                Console.WriteLine("Program runs successfully");
            else
                Console.WriteLine("Program condition is failure");

            Console.WriteLine("Finish");
            Console.ReadLine();
        }


        static ulong Sum(ulong n)
        {
            ulong sum = 0;

            for (ulong i = 1; i <= n; i++)
                sum = sum + i;

            return sum;
        }

        //Body Expression
        static ulong Sum2(ulong n) => n * (n + 1) / 2;

        static ulong SumWithPerformance(ulong n)
        {
            ulong sum = 0;

            for (ulong i = 1; i <= n; i++)
            {
                sum += i;//sum = sum + i
                Thread.Sleep(100); //1s = 1000ms
                Console.Write(".");
            }
            return sum;
        }
    }
}
