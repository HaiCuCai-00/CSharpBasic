using System;

namespace _63.Misc.Exercise.MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //var square = new int[3, 3]
            //{
            //    {8, 1, 6 },
            //    {3, 5, 7 },
            //    {4, 9, 2 }
            //};

            var square = new int[3, 3]
           {
                {10, 3, 8 },
                {5, 7, 9 },
                {6, 11, 4 }
           };
            int[] result = new int[8];
            //{row 1, row 2, row 3, column 1,column 2, column 3, right cross line, left cross line}

            for (int i = 0; i < square.GetLength(0); i++)
            {
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    result[i] += square[i, j];
                    result[i + 3] += square[j, i];
                }
                result[result.Length - 2] += square[i, i];
                result[result.Length - 1] += square[i, square.GetLength(0) - i - 1];
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
