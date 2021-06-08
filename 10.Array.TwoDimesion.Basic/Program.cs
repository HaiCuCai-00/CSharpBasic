using System;

namespace _10.Array.TwoDimesion.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrl = new int[2, 4];

            arrl[0, 0] = 1;
            arrl[0, 1] = 2;
            arrl[0, 2] = 3;
            arrl[0, 3] = 4;

            arrl[1, 0] = 5;
            arrl[1, 1] = 6;
            arrl[1, 2] = 7;
            arrl[1, 3] = 8;

            foreach (var item in arrl)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();

            int[,] arr2 = new int[2, 4]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 }
            };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"{arr2[i, j]}");
                }
                Console.WriteLine();

                

              
            }
            int[,,] arr3 = new int[3, 3, 3]
                {
                    { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} },
                    { {10, 11, 12}, {13, 14, 15}, {16, 17, 18} },
                    {{ 19, 20, 21}, {22, 23, 24}, {25, 26, 27} },
                };
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                Console.WriteLine($"");
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    for (int t = 0; t < arr3.GetLength(2); t++)
                    {
                        Console.Write($"{arr3[i, j, t]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
