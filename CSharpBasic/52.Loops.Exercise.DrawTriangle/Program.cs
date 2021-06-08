using System;

namespace _52.Loops.Exercise.DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * n = 5
             * 
             * *
             * **
             * ***
             * ****
             * *****
             * Exercise 2:
             * Research char type?
             * Use For Loop print a => z
             */

            DrawWithForLoop();
            DrawWithDoWhileLoop();
            DrawWithWhileLoop();
            DrawWithRecusiveLoop();
        }

        static void DrawWithForLoop()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        static void DrawWithDoWhileLoop()
        {
            int n = 5;
            int i = 1;

            do
            {
                int j = 1;
                do
                {
                    Console.Write("*");
                    j++;
                } while (j <= i);
                Console.WriteLine();
                i++;
            } while (i <= n);
        }

        static void DrawWithWhileLoop()
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
            Draw(1, 5);
            Draw2(5);

            void Draw(int i , int n)
            {
                if (i > n) return;

                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine();
                Draw(i + 1, n);
            }
     
            void Draw2(int n)
            {
                Row(1);

                void Row(int i)
                {
                    if (i > n) return;
                    Asterisk(1);
                    Console.WriteLine();
                    Row(i + 1);

                    void Asterisk(int j)
                    {
                        if (j > i) return;
                        Console.Write("*");
                        Asterisk(j + 1);
                    }
                }
            }
        }
    }
}
