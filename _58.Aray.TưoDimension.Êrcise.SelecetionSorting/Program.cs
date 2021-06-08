using System;

namespace _58.Aray.TưoDimension.Êrcise.SelecetionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[2, 4]
            {
                {3, 30, 9, 0 },
                {1, 2, 10, 4 }
            };

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int colum = 0; colum < numbers.GetLength(1); colum++)
                {
                    Console.Write($"{numbers[row, colum]}  ");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int colum = 0; colum < numbers.GetLength(1); colum++)
                {
                    var min = (row, colum);
                    for (int rowx = row; rowx < numbers.GetLength(0); rowx++)
                    {
                        for (int columx = (rowx == row ? colum +1 : 0); columx < numbers.GetLength(1); columx++)
                        {
                            if (numbers[rowx, columx] < numbers[min.row, min.colum])
                            {
                                min = (rowx, columx);
                            }
                        }
                    }
                    (numbers[row, colum], numbers[min.row, min.colum])
                        = (numbers[min.row, min.colum], numbers[row, colum]);
                }
            }
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int colum = 0; colum < numbers.GetLength(1); colum++)
                {
                    Console.Write($"{numbers[row, colum]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
