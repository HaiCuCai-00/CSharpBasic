using System;
using System.Diagnostics;

namespace _51.Condition.Switch.Exercise.Money
{
    class Program
    {
        /*
         * 500_000
         * 200_000
         * 100_000
         *  50_000
         *  20_000
         *  10_000
         *   5_000
         *   2_000
         *   1_000
         */

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int loops = 1000;

            //Run Test 1
            Console.WriteLine();
            stopwatch.Start();
            for (int i = 0; i < loops; i++)
                Test1();
            stopwatch.Stop();
            var result1 = stopwatch.ElapsedMilliseconds;

            //Run Test 1 Cool
            Console.WriteLine();
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < loops; i++)
                Test1_Cool();
            stopwatch.Stop();
            var result1_cool = stopwatch.ElapsedMilliseconds;

            //Run Test 2
            Console.WriteLine();
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < loops; i++)
                Test2();
            stopwatch.Stop();
            var result2 = stopwatch.ElapsedMilliseconds;

            //Run Test 2 Cool
            Console.WriteLine();
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < loops; i++)
                Test2_Cool();
            stopwatch.Stop();
            var result2_cool = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Test 1: {result1}");
            Console.WriteLine($"Test 1 Cool: {result1_cool}");
            Console.WriteLine($"Test 2: {result2}");
            Console.WriteLine($"Test 2 Cool: {result2_cool}");
        }

        private static void Test1()
        {
            int amount = 5_388_000;
            int count = 0;

            if (amount >= 500_000)
            {
                Console.WriteLine($"500000: {count = amount / 500_000}");
                amount -= 500_000 * count;
            }

            if (amount >= 200_000)
            {
                Console.WriteLine($"200000: {count = amount / 200_000}");
                amount -= 200_000 * count;
            }

            if (amount >= 100_000)
            {
                Console.WriteLine($"100000: {count = amount / 100_000}");
                amount -= 100_000 * count;
            }

            if (amount >= 50_000)
            {
                Console.WriteLine($"50000: {count = amount / 50_000}");
                amount -= 50_000 * count;
            }

            if (amount >= 20_000)
            {
                Console.WriteLine($"20000: { count = amount / 20_000}");
                amount -= 20_000 * count;
            }

            if (amount >= 10_000)
            {
                Console.WriteLine($"10000: {count = amount / 10_000}");
                amount -= 10_000 * count;
            }

            if (amount >= 5_000)
            {
                Console.WriteLine($"5000: {count = amount / 5_000}");
                amount -= 5_000 * count;
            }

            if (amount >= 2_000)
            {
                Console.WriteLine($"2000: {count = amount / 2_000}");
                amount -= 2_000 * count;
            }

            if (amount >= 1_000)
            {
                Console.WriteLine($"1000: {count = amount / 1_000}");
                amount -= 1_000 * count;
            }
        }
        private static void Test1_Cool()
        {
            int amount = 5_388_000;
            int count = 0;

            Split(500_000);
            Split(200_000);
            Split(100_000);
            Split(50_000);
            Split(20_000);
            Split(10_000);
            Split(5_000);
            Split(2_000);
            Split(1_000);

            void Split(int denomination)
            {
                if (amount >= denomination)
                {
                    Console.WriteLine($"{denomination}: {count = amount / denomination}");
                    amount -= denomination * count;
                }
            }
        }
        private static void Test2()
        {
            #region Note
            /*
             * 1k
             * 2k
             * 3k = 2k + 1k
             * 4k = 2k + 2k
             * 5k
             * 6k = 5k + 1k
             * 7k = 5k + 2k
             * 8k = 5k + 2k + 1k
             * 9k = 5k + 2k + 2k
             * => /1
             * 
             * 10k
             * 20k
             * 30k = 20k + 10k
             * 40k = 20k + 20k
             * 50k
             * 60k = 50k + 10k
             * 70k = 50k + 20k
             * 80k = 50k + 20k + 10k
             * 90k = 50k + 20k + 20k
             *=> /10
             * 
             * 100k
             * 200k
             * 300k = 200k + 100k
             * 400k = 200k + 200k
             *=> /100
             * 
             * 500k
             *=> /500
             *
             *amount = 1_125_000
             *count = amount / 500 = 2 (remain amount = 125k)
             *count = amount / 100 = 1 (remain amount =  25k)
             *count = amount /  10 = 2 (remain amount =   5k)
             *count = amount /   1 = 5 (remain amount =   0k) 
             */
            #endregion

            int amount = 5_388_000;
            int count = 0;

            if (amount >= 500_000)
            {
                Console.WriteLine($"500000: { count = amount / 500_000}");
                amount -= count * 500_000;
            }

            if (amount >= 100_000)
            {
                Console.WriteLine((count = amount / 100_000) switch
                {
                    3 => $"200000: 1\n100000: 1",
                    4 => $"200000: 2",
                    _ => $"{count}00000: 1"
                });
                amount -= count * 100_000;
            }

            if (amount >= 10_000)
            {
                Console.WriteLine((count = amount / 10_000) switch
                {
                    3 => $"20000: 1\n10000: 1",
                    4 => $"20000: 2",
                    6 => $"50000: 1\n10000: 1",
                    7 => $"50000: 1\n20000: 1",
                    8 => $"50000: 1\n20000: 1\n10000: 1",
                    9 => $"50000: 1\n20000: 2",
                    _ => $"{count}0000: 1"
                });
                amount -= count * 10_000;
            }

            if (amount >= 1_000)
            {
                Console.WriteLine((count = amount / 1_000) switch
                {
                    3 => $"2000: 1\n1000: 1",
                    4 => $"2000: 2",
                    6 => $"5000: 1\n1000: 1",
                    7 => $"5000: 1\n2000: 1",
                    8 => $"5000: 1\n2000: 1\n1000: 1",
                    9 => $"5000: 1\n2000: 2",
                    _ => $"{count}000: 1"
                });
                amount -= count * 1_000;
            }

        }
        private static void Test2_Cool()
        {
            var amount = 5_388_000;
            var count = 0;
            var tail = "00000";

            if (amount >= 500_000)
            {
                Console.WriteLine($"5{tail}: { count = amount / 500_000}");
                amount -= count * 500_000;
            }

            for (int denomination = 100_000; denomination >= 1_000; denomination /= 10)
            {
                if (amount >= denomination)
                {
                    Console.WriteLine((count = amount / denomination) switch
                    {
                        3 => $"2{tail}: 1\n1{tail}: 1",
                        4 => $"2{tail}: 2",
                        6 => $"5{tail}: 1\n1{tail}: 1",
                        7 => $"5{tail}: 1\n2{tail}: 1",
                        8 => $"5{tail}: 1\n2{tail}: 1\n1{tail}: 1",
                        9 => $"5{tail}: 1\n2{tail}: 2",
                        _ => $"{count}{tail}: 1"
                    });
                    amount -= count * denomination;
                }
                tail = tail[0..^1];
            }
        }

    }
}
