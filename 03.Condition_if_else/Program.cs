using System;

namespace _03.Condition_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *  month = 1,2,3 => quarter 1
            *  month = 4,5,6 => quarter 2
            *  month = 7,8,9 => quarter 3
            *  month = 10, 11, 12 => quarter 4
            */
          
            int quarter = 0;
            for ( int i =1; i < 13; i++)
            {
                string message = string.Empty; //chuỗi trống 
                int month = i;
                // Version 1
                if (month < 4)
                    message = $"{month} month is quarter 1";
                else if (month < 7)
                    message = $"{month} month is quarter 2";
                else if (month < 10)
                    message = $"{month} month is quarter 3";
                else
                    message = $"{month} month is quarter 4";
                // Version 1 => 2
                if (month < 4) quarter = 1;
                else if (month < 7) quarter = 2;
                else if (month < 10) quarter = 3;
                else quarter = 4;

                Console.WriteLine($"{month} month is quarter {(month + 2) / 3}");

                Console.WriteLine(message);
            }
            // Vesion3
            /*int month is item of    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
             * each item / 3        = { 0, 0, 1, 1, 1, 2, 2, 2, 3, 3,   3,  3}
             * each ((item + 2) / 3 = { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4,   4,  4}
             */
            Console.WriteLine();
            for (int j = 1; j <= 12; j++)
            {
                int month = j;
                Console.WriteLine($"{month} month is quarter {(month + 2) / 3}");
            }
            Console.ReadLine();
        }
    }
}
