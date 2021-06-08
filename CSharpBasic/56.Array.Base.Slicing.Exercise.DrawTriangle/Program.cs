using System;

namespace _56.Array.Basic.Exercise.Slicing.DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * n = 5
             * 
             * *****
             * ****
             * ***
             * **
             * *
             *
             */

            int n = 5;

            for (int i = n; i >=1 ; i--)
            {
                for (int j = i; j >=1; j--)
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.WriteLine();


            string starts = "*****"; 
            /*
             *                          0    1    2    3    4   5
             * char[] starts = new [] {'*', '*', '*', '*', '*'}
             *                         ^5   ^4   ^3   ^2   ^1  ^0
             */
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(starts);
                starts = starts[..^1]; //starts[0..^1]
            }
        }
    }
}
