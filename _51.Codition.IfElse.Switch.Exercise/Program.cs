using System;
using System.Diagnostics;
namespace _51.Codition.IfElse.Switch.Exercise
{
    class Program
    {
        /*
         *  500_000
         *  200_000
         *  100_000
         *   50_000
         *   20_000
         *   10_000
         *    5_000
         *    2_000
         *    1_000
         */
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Test1();

            Test1();

        }

        private static void Test1()
        {
            int amount = 210_000;

            // 5_210_000 : 500_000 = 10

            int count = amount / 500_000;
            if (count > 0)
            {
                Console.WriteLine($"500_000: {count}");
                amount -= 500_000 * count; //amount = amount - 500_00 * count;
            }

            //210_000
            count = amount / 200_000;
            if (count > 0)
            {
                Console.WriteLine($"200_000:{count}");
                amount -= 200_000 * count;
            }

            //100_000
            count = amount / 100_000;
            if (count > 0)
            {
                Console.WriteLine($"100_000:{count}");
                amount -= 100_000 * count;
            }

            //50_000
            count = amount / 50_000;
            if (count > 0)
            {
                Console.WriteLine($"50_000:{count}");
                amount -= 50_000 * count;
            }

            //20_000
            count = amount / 20_000;
            if (count > 0)
            {
                Console.WriteLine($"20_000:{count}");
                amount -= 20_000 * count;
            }


            //10_000
            count = amount / 10_000;
            if (count > 0)
            {
                Console.WriteLine($"10_000:{count}");
                amount -= 10_000 * count;
            }

            //5_000
            count = amount / 5_000;
            if (count > 0)
            {
                Console.WriteLine($"5_000:{count}");
                amount -= 5_000 * count;
            }

            //2_000
            count = amount / 2_000;
            if (count > 0)
            {
                Console.WriteLine($"2_000:{count}");
                amount -= 2_000 * count;
            }

            //1_000
            count = amount / 1_000;
            if (count > 0)
            {
                Console.WriteLine($"1_000:{count}");
                amount -= 1_000 * count;
            }
        }
        private static void Test2()
        {
            /*
             * 1k
             * 2k
             * 3k = 1k + 2k
             * 5k
             * 6k = 6k + 1k
             * 7k = 5k + 2k
             * 8k = 5k + 2k + 1k
             * 10k
             * 20k
             * 30k = 10k + 20k
             * 40k = 20k + 20k
             * 50k
             * 60k = 50k + 10k
             * 70k = 50k + 20k
             * 80k = 50k + 20k + 10k
             * 90k = 50k + 20k +20k
             * => /100
             * 
             * 100k
             * 200k
             * 300k = 200k + 100k
             * 400k = 200k + 200k
             * 500k
             * => /500
             * 
             * amount = 1_125_000
             * count = amount / 500 ( => 2) (remain amount = 125k)
             * count = amount / 100 (=> 1) (remain amount = 25k)
             * count = amount /  10 ( => 2) (remain amount = 5k)
             * count = amount /   1 ( => 5) (remain amount = 0k)
             */

            int amount = 1_125_000;
            int count = 0;
            if (amount >= 500_000)
            {
                count = amount / 500_000;
                amount -= count * 500_000;
                Console.WriteLine($"500_000: {count}");
            }

            if (amount >= 100_000)
            {
                count = amount / 100_000;
                amount -= count * 100_000;
                Console.WriteLine(count switch
                {
                    3 => $"200_000: 1\n10_000: 1" ;
                    4 => $"200_000: 2";
                    _ => $"{count}00_000: {count}"
                }
                                  );
            }

             
        }
    }
}
