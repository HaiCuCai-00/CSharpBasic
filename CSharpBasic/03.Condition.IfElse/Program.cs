using System;

namespace _03.Condition.IfElse
{
    //Exercise 2: Cho number = (mot so bat ky tu 1 den 12 - la thang cua nam), in ra thang nay thuoc quy nao
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * month = 1, 2, 3 => quarter 1
             * month = 4, 5, 6 => quarter 2
             * month = 7, 8, 9 => quarter 3
             * month = 10, 11, 12 => quarter 4
             */

            //Version 1
            int quarter = 0;

            for (int i = 1; i <= 12; i++)
            {
                if (i < 4) quarter = 1;
                else if (i < 7) quarter = 2;
                else if (i < 10) quarter = 3;
                else quarter = 4;

                Console.WriteLine($"Month {i} is quarter {quarter}");
            }

            //Version 2
            //(int) "month" is item of { 1 , 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }
            //each (item / 3)        = { 0,  0, 1, 1, 1, 2, 2, 2, 3,  3,  3,  4}
            //each ((item + 2) / 3)  = { 1 , 1, 1, 2, 2, 2, 3, 3, 3,  4,  4,  4}

            Console.WriteLine();

            for (int i = 1; i <= 12; i++)
                Console.WriteLine($"Month {i} is quarter {(i + 2) / 3}");
            Console.ReadLine();
        }


    }
}
