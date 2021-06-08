using System;

namespace _58.Array.TwoDimension.Exercise.SelectionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            SortArray1();
            Console.WriteLine("-------------------------");
            SortArray2();
        }

        private static void SortArray1()
        {
            var numbers = new int[2, 4]
            {
                { 3, 20, 9, 0 },
                { 1, 2, 10, 4 }
            };


            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int column = 0; column < numbers.GetLength(1); column++)
                {
                    var min = (row, column);

                    for (int rowx = row; rowx < numbers.GetLength(0); rowx++)
                    {
                        for (int columnx = (rowx == row ? column + 1 : 0); columnx < numbers.GetLength(1); columnx++)
                        {
                            if (numbers[rowx, columnx] < numbers[min.row, min.column])
                                min = (rowx, columnx);
                        }
                    }

                    (numbers[row, column], numbers[min.row, min.column])
                        = (numbers[min.row, min.column], numbers[row, column]);
                }
            }

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int column = 0; column < numbers.GetLength(1); column++)
                {
                    Console.Write($"{numbers[row, column], 2} ");
                }
                Console.WriteLine();
            }
        }

        private static void SortArray2()
        {
            var numbers = new int[2, 4]
            {
                { 3, 20, 9, 0 },
                { 1, 2, 10, 4 }                        
            };


            for (int i = 0; i < numbers.Length; i++)
            {
                var current = ConvertFrom1DTo2D(i);
                var min = current;

                for(int j = i + 1; j < numbers.Length; j++)
                {
                    var temp = ConvertFrom1DTo2D(j);

                    if (numbers[temp.row, temp.column] < numbers[min.row, min.column])
                        min = temp;
                }
                (numbers[current.row, current.column], numbers[min.row, min.column])
                    = (numbers[min.row, min.column], numbers[current.row, current.column]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                var current = ConvertFrom1DTo2D(i);
                Console.Write($"{numbers[current.row, current.column], 2} ");

                if (current.column == (numbers.GetLength(1) - 1)) Console.WriteLine();
            }

            //Local Method
            (int row, int column) ConvertFrom1DTo2D(int position)
                => (position / numbers.GetLength(1), position % numbers.GetLength(1));

        }

        //private static (int row, int column) ConvertFrom1DTo2D(int position, int[,] arr)
        //    => (position / arr.GetLength(1), position % arr.GetLength(1));

    }
}
