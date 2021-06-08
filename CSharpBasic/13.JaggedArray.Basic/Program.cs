using System;

namespace _13.JaggedArray.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ages = new int[5, 5] //[0,1]
            {
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 }
           };

            for (int i = 0; i < ages.GetLength(0); i++)
            {
                for (int j = 0; j < ages.GetLength(1); j++)
                    Console.Write($"{ages[i, j]} ");
                Console.WriteLine();
            }


            Console.WriteLine("---------------------------");
            int[][] numbers = new int[5][]
            {
                new int[] {1, 2, 3, 4, 5},
                new int[] {6, 7, 8},
                new int[] {9, 10, 11, 12},
                new int[] {13, 14, 15},
                new int[] {16, 17},
            };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                    Console.Write($"{numbers[i][j],2} ");
                Console.WriteLine();
            }

        }
    }
}
