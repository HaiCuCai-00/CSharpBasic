using System;

namespace _07.Loops.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //n = 1 => 1 = 1^2
            //n = 2 => 1 + 3 = 2^2
            //n = 3 => 1 + 3 +5 = 3^2
            //n = 4 => 1 + 3 + 5 + 7 = 4^2
            //n = 6 => 1 + 3 + 5 + 7 + 9 + 11 = 6^2
            LearnForLoop();
            LearnForDoWhile();
            LearnForWhile();
            LearnForRecursive();
            Console.WriteLine();
        }

        static void LearnForLoop()
        {
            int n = 6;
            int sum = 0;
            //{} Block code
            for (int i = 1; i <= n ; i++)
            {
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum = {sum}");

            int j = 1;
            int sum2 = 0;
            for(; ; )
            {
                if (j <= n)
                    sum2 += 2 * j - 1;
                else
                    break;
                //j = j + 1;
                // J += 1;
                j++;
            }
            Console.WriteLine($"Sum = {sum2}");
        }
        
        //Do-While
        static void LearnForDoWhile()
        {
            int n = 6;
            int sum = 0;

            int i = 1;
            do
            {
                sum += 2 * i - 1;
                i++;
            } while (i <= n);
            Console.WriteLine($"Sum = {sum}");
        }

        //While
        static void LearnForWhile()
        {
            int n = 6;
            int sum = 0;

            int i = 1;
            while (i <= n)
            {
                sum += 2 * i - 1;
                i++;
            }
            Console.WriteLine($"Sum = {sum}");
        }

        //ForEach

        //Recursive
        static void LearnForRecursive()
        {
            /* Sum(6)
             * => 11 + Sum(5)
             * => 11 + 9 + Sum(4)
             * => ...
             * => 11 + 9 + 7 + 5 + 3 + 1 + Sum(0)
             * => 11 + 9 + 7 + 5 + 3 +1 + 0
             */
            int sum = Sum(6);
            Console.WriteLine($"Sum = {sum} ");
            int Sum(int n)
            {
                if (n < 1) return 0;

                return (2 * n - 1) + Sum(n - 1);
            }

            int sum2 = Sum2(6);
            int Sum2(int n) => n < 1 ? 0 : ((2 * n - 1) + Sum2(n - 1));
            Console.WriteLine($"Sum2 = {sum2}");
            
        }
    }
}
