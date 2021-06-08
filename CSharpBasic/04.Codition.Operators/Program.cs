using System;

namespace _04.Codition.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logical Operator: && || ^ !
            //Bitwise Operator: &  |  ^  ~ << >>

            //&& versus &

            int number = 10;

            //Case 1
            if (number > 5 || number < 9 && IsDivededBy(number, 0))
                Console.WriteLine($"{number} is valid.");

            //1 => Print result
            //2 => Error
            //3 => Nothing     (This case)
            /*
             * number = 10
             * number > 5      (True)
             * number < 9      (False)
             * number / 0 == 0 (Error)
             * 
             * (number > 5) && (number < 9) && (number / 0 == 0)
             * => True && False && (True/False/Error)
             */

            //Case 2
            //if(number > 5 & number < 9 & IsDivededBy(number, 0))
            //    Console.WriteLine($"{number} is valid.");

            //1 => Print result 
            //2 => Error        (This case)
            //3 => Nothing    
            /*
           * number = 10
           * number > 5      (True)  = 1
           * number < 9      (False) = 0
           * number / 0 == 0 (Error)
           * 
           * (number > 5) & (number < 9) & (number / 0 == 0)
           * => True & False & Error
           * => 1    & 0     & _     = 0 & Error
           */

            int a = 10;
            int b = 12;
            //Console.WriteLine($"a && b = { a && b }"); // && is not apply for int type
            Console.WriteLine($"a &  b = { a & b}");
            Console.WriteLine("Finish");
            Console.WriteLine($"8 & Convert(true)  = {8 & Convert.ToInt32(true)}");
            Console.WriteLine($"1 & Convert(false) = {1 & Convert.ToInt32(false)}");
            Console.WriteLine($"Convert(1)  = {Convert.ToBoolean(1)}"); //True
            Console.WriteLine($"Convert(0)  = {Convert.ToBoolean(0)}"); //False
            Console.WriteLine($"Convert(-1) = {Convert.ToBoolean(-1)}");//True
        
            Console.ReadLine();
        }

        //[Body Expression]
        static bool IsDivededBy(int dividend, int divisor)
            => dividend / divisor == 0;


    }
}
