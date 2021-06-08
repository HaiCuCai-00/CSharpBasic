using System;

namespace _04.Codition.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical operator: && || ^|
            //Bitwise operator: & | ^ ~ << >>

            //&& versus &

            int number = 10;
            if (number > 5 && number < 9 && IsDivedeBy(number, 0))
                Console.WriteLine($"{number} is valid.");
            // 1 => Print result
            // 2 => Error
            // 3 => Nothing ( This case)
            /*
             * number = 10
             * number > 5   (True)
             * number < 9   (False)
             * number / 0 ==0 (Error)
             * 
             * 
             */
            // if( number >5 & number < 9 & IsDivedeBy(number , 0))
            int a = 12;
            int b = 10;
            Console.WriteLine($"a & b = {a & b}");
            Console.WriteLine("Finish");
            Console.WriteLine($" 8 & true = {8 & Convert.ToInt32(true)}");
            Console.WriteLine(Convert.ToInt32(true));
            Console.WriteLine($"Convert(1) = { Convert.ToBoolean(1)}" );
            Console.ReadLine();
        }

        static bool IsDivedeBy(int dividend, int divisor)
            => dividend / divisor == 0;
        /*
             * var a = ( dividend / divisor ) == 0;
             * if ( dividend / divisor  == 0 )
             *  return true;
             * else
             *  return false;
             */
        //return dividend / divisor == 0;
    }




}
