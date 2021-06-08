using System;

namespace _59.Array.ThreeDimension.Exercise.SelectionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[,,] {
                {
                    { 3, 20,  9, 0 },
                    { 1,  2, 10, 4 }
                },
                {
                    { 3, 20,  9, 0 },
                    { 1,  2, 10, 4 }
                },
                {
                    { 3, 20,  9, 0},
                    { 1,  2, 10, 4}
                }
            };

            SortArray(numbers);
            DisplayArray(numbers);
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

        private static void SortArray(int[,,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var current = ConvertFrom1DTo3D(array, i);
                var min = current;

                for (int j = i + 1; j < array.Length; j++)
                {
                    var temp = ConvertFrom1DTo3D(array, j);
                    if (array[temp.plane, temp.row, temp.column] < array[min.plane, min.row, min.column])
                        min = temp;
                }


                (array[current.plane, current.row, current.column], array[min.plane, min.row, min.column])
                    = (array[min.plane, min.row, min.column], array[current.plane, current.row, current.column]);
            }
        }

        private static void DisplayArray(int[,,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var p = ConvertFrom1DTo3D(array, i);

                if (p.row == 0 && p.column == 0)
                    Console.WriteLine($"Plane: {p.plane}");

                if (p.column == 0)
                    Console.Write("\t");

                Console.Write($"{array[p.plane, p.row, p.column]} ");

                if (p.column == (array.GetLength(2) - 1))
                    Console.WriteLine();
            }
        }
    }
}
