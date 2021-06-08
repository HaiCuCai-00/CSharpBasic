using System;

namespace _11.Array.TwoDimension.Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[,]
            {
                { 1, 2, 3, 4},
                { 5, 6, 7, 8},
                { 9, 10, 11, 12}
            };

            foreach (var item in numbers)
                Console.Write($"{item} ");

            Console.WriteLine("\n------------------------");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                    Console.Write($"{numbers[i, j],2} ");

                Console.WriteLine();
            }

            /*
             *
             * 2D -> 1D
             * Array[Rows, Columns]
             * Array[i;j] -> Array[t]
             * 
             * i,j => t
             * t = i * Columns + j (Columns = Number of columns of 2D Array)
             * 
             * Address at [i;j] =  Base Address + (Size Of Type) * (i * Columns + j)
             * 
             * t => i, j
             * i = t / Columns 
             * j = t % Columns (Mod)
             * 
             */

            Console.WriteLine("------------------------");

            for (int t = 0; t < numbers.Length; t++)
            {
                var position = (i: t / numbers.GetLength(1), j: t % numbers.GetLength(1));

                Console.Write($"{numbers[position.i, position.j], 2} ");

                if(position.j == (numbers.GetLength(1) - 1))
                    Console.WriteLine();

            }
        }
    }
}
