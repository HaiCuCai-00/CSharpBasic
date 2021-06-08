using System;

namespace _12.Array.ThreeDimension.Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[2, 2, 2]// [Planes, Rows, Columns]
            {
                {
                    { 1, 2 },
                    { 3, 4 }
                },
                {
                    { 5, 6},
                    { 7, 8}
                }
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine($"Plane {i}");
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int t = 0; t < numbers.GetLength(2); t++)
                    {
                        if (t == 0) Console.Write("\t");
                        Console.Write($"{numbers[i, j, t]} ");
                    }
                    Console.WriteLine();
                }
            }

            #region N Dimension to 1 Dimension

            /*
             *
             * 2D -> 1D
             * Array[Rows, Columns]
             * Array[i;j] -> Array[t]
             * 
             * i, j => t
             * t = i * Columns + j (Columns = Number of columns of 2D Array)
             * 
             * Address at [i;j] =  Base Address + (Size Of Type) * (i * Columns + j)
             * 
             * t => i, j
             * i = t / Columns 
             * j = t % Columns (Mod)
             * ------------------------------------------------------------------------------
             * 
             * 3D -> 1D
             * Array[Planes, Rows, Columns]
             * Array[i;j;v] -> Array[t]
             * 
             * i, j, v => t
             * t = i * Rows * Columns 
             *          + j * Columns 
             *              + v
             *              
             * t => i, j, v
             * 
             * ------------------------------------------------------------------------------
             * 
             * 4D -> 1D
             * Array[Blocks, Planes, Rows, Columns]
             * Array[i;j;v;u] -> Array[t]
             * 
             * i, j, v, u => t
             * t = i * Planes * Rows * Columns 
             *            + j * Rows * Columns 
             *                   + v * Columns 
             *                       + u
             * ------------------------------------------------------------------------------
             * 
             * 5D -> 1D
             * Array[Universes, Blocks, Planes, Rows, Columns]
             * Array[i;j;v;u;z] -> Array[t]
             * 
             * i, j, v, u, z => t
             * t = i * Blocks * Planes * Rows * Columns
             *            + j * Planes * Rows * Columns
             *                     + v * Rows * Columns
             *                            + u * Columns
             *                                + z
             * ------------------------------------------------------------------------------                                
             */
            #endregion

            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                var p = ConvertFrom1DTo3D(numbers, i);

                if (p.row == 0 && p.column == 0) 
                    Console.WriteLine($"Plane: {p.plane}");

                if (p.column == 0) 
                    Console.Write("\t");

                Console.Write($"{numbers[p.plane, p.row, p.column]} ");

                if (p.column == (numbers.GetLength(2) - 1)) 
                    Console.WriteLine();
            }
        }

        private static (int plane, int row, int column) ConvertFrom1DTo3D(int[,,] array, int t)
        {
            //i = t / (Rows * Columns)
            int i = t / (array.GetLength(1) * array.GetLength(2));

            //b = t % (Rows * Columns)
            int b = t % (array.GetLength(1) * array.GetLength(2));

            //j = b / Columns
            int j = b / array.GetLength(2);

            //v = b % Columns
            int v = b % array.GetLength(2);

            return (i, j, v);
        }
    }
}
