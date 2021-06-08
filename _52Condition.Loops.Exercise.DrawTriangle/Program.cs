using System;

namespace _52Condition.Loops.Exercise.DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * n = 5
             *  *
             *  **
             *  ***
             *  ****
             *  *****
             *  //Exercise
             *      *
             *     ***
             *    *****
             *  //Exercise 2:
             *  Research char type?
             *  Use For Loop print a => z
             */
           // DrawWithWhile();
            DrawWithRecusiveLoop();
   
        }

        static void DrawTriangleForLoops()
        {
            int n = 5;
            /*
            for (int i = 1; i <= n; i++)
            {
                
                for (int j =1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
               

            }
             */
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.Write("*");
                    j++;
                } while (j<=i);
                Console.WriteLine();
                i++;
            } while (i<=n);
        }
        static void DrawWithWhile()
        {
            int n = 5;

            int i = 1;
            while (i <= n)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
        static void DrawWithRecusiveLoop()
        {
            /*
            Asterisk(1, 5);
                void Asterisk(int i, int n)
                {
                    if (i > n) return;
                    for (int J = 1; J <= i; J++)
                        Console.Write("*");
                    Console.WriteLine();
                    Asterisk(i + 1, n);
                }
            */
            DrawAsterisk(5);
            void DrawAsterisk(int n)
            {
                RowAsterisk(1);
                void RowAsterisk(int i)
                {
                    if (i > n) return;
                    Asterisk(1);
                    /*
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    */
                    void Asterisk(int j)
                    {
                        if (j > i) return;
                        Console.Write("*");
                        Asterisk(j + 1);
                    }
                    Console.WriteLine();
                   
                    RowAsterisk(i + 1);
                }
            }
        }
    }
}
