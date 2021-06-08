using System;

namespace _53.Loops.Exercise.Draw.Isosceles.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Lfor();

            LWhile();

            LDoWhile();

            LRercusive(5);
        }

        //currying

        private static void LRercusive(int n)
        {
            /* if (i > n) return;
             int j = 1;
             while (j <= n - i)
             {
                 Console.Write(" ");
                 j++;
             }
             int t = 1;
             while (t <= 2 * i - 1)
             {
                 Console.Write("*");
                 t++;
             }

             Console.WriteLine();
             LRercusive(n, ++i);
            */
            Row(1);
            void Row(int i)
            {
                if (i > n) return;
                /*int j = 1;
                while (j <= n - i)
                {
                    Console.Write(" ");
                    j++;
                }
               */
                /*int t = 1;
               while (t <= 2 * i - 1)
               {
                   Console.Write("*");
                   t++;
               }
               */
                Space(1);
                Asterist(1);
                void Space(int j)
                {
                    if (j > n - i) return;
                    Console.Write(" ");
                    Space(++j);
                }
                void Asterist(int t)
                {
                    if (t > 2 * i - 1) return;
                    Console.Write("*");
                    Asterist(++t);
                }
               
                Console.WriteLine();
                Row(++i);
            }



        }

        private static void LDoWhile()
        {
            int n = 5;
            int i = 1;
            do
            {
                int j = 1;
                if (n - i != 0)
                    do
                    {

                        Console.Write(" ");
                        j++;
                    } while (j <= n - i);
                int t = 1;
                do
                {

                    Console.Write("*");
                    t++;
                } while (t <= 2 * i - 1);
                Console.WriteLine();
                i++;
            } while (i <= n);
        }

        private static void LWhile()
        {
            int n = 5;
            int i = 1;
            while (i <= n)
            {
                int j = 1;
                while (j <= n - i)
                {
                    Console.Write(" ");
                    j++;
                }

                int t = 1;
                while (t <= 2 * i - 1)
                {
                    Console.Write("*");
                    t++;
                }

                Console.WriteLine();
                i++;
            }
        }

        private static void Lfor()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (int t = 1; t <= 2 * i - 1; t++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
