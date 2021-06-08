using System;

namespace _51.Condition.IfElse.Exercise.MilkTea
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVersion2();
        }
        static void Version1(string[] args)
        /*
         * Main Item
         * - Milk Tea: 10.000
         * - Olong Tea: 20.000
         * 
         * Topping Item:
         * - Cherry: 6.000
         * - Flan : 7.000
         * - Jelly: 8.000
         * - Cheese: 9.000
         */

        // có 32 bit = 16bit (main iteam) - 16bit(topping)
        {
            // Main Item
            decimal MilkTeaPrice = 10_000.000M; // kiểu dữ liệu lưu trữ thập phân gồm : Decimal, double, float 
            int milkTea = 0b0000_0000_0000_0001_0000_0000_0000_0000; ;

            decimal olongTeaPrice = 20_000M;
            int olongTea = 0b0000_0000_0000_0010_0000_0000_0000_0000;

            //Tooping Item
            decimal cherryPrice = 6_000M;
            int cherry = 0b0000_0000_0000_0000_0000_0000_0000_0001;

            decimal flanPrice = 7_000m;
            int flan = 0b0000_0000_0000_0000_0000_0000_0000_0010;

            decimal jellyPrice = 8_000m;
            int jelly = 0b0000_0000_0000_0000_0000_0000_0000_0100;

            decimal cheesePrice = 9_000m;
            int cheese = 0b0000_0000_0000_0000_0000_0000_0000_1000;

            int order1 = milkTea | cherry | cheese;
            Console.WriteLine($"Order1: {Convert.ToString(order1, 2)}");

            int order2 = olongTea | flan | cheese;
            Console.WriteLine($"Order2: {Convert.ToString(order2, 2)}");

            Console.WriteLine(2 << 3);
            Console.WriteLine(8 >> 2);
            Console.WriteLine(8 >> 4);

            byte a = 0b1000;
            Console.WriteLine(a);
            Console.WriteLine(a >> 4);

            // 00001 mon A
            // 00010 mon B
            // 00100 mon C
            // 01000 mon D
            // 10000 mon E

            // 10100 mon C va E
            // 10100 >> 0 => 10100 & 1 = 00000 = 0
            // 10100 >> 1 => 10100 & 1 = 00000 = 0
            // 10100 >> 2 => 00101 & 1 = 00001 = 1
            // 10100 >> 3 => 00101 & 1 = 00001 = 1
            // 10100 >> 4 => 00001 & 1 = 00001 = 1

            decimal totall = 0m;
            //Calculate Main Item Price
            if ((order1 >> 16 & 1) == 1) totall += MilkTeaPrice;
            if ((order1 >> 17 & 1) == 1) totall += olongTeaPrice;

            //Calculate Topping Price
            if ((order1 >> 0 & 1) == 1) totall += cherryPrice;
            if ((order1 >> 1 & 1) == 1) totall += flanPrice;
            if ((order1 >> 2 & 1) == 1) totall += jellyPrice;
            if ((order1 >> 3 & 1) == 1) totall += cheesePrice;

            Console.WriteLine($"Total of order 1 is ${totall}");

            int bits = 0b0000_0000_0000_0000_0000_0000_0000_0000;
            Console.WriteLine("Hello World!");
        }
        static void TestVersion2()
        {

            // 00001 mon A
            // 00010 mon B
            // 00100 mon C
            // 01000 mon D
            // 10000 mon E

            //10100 mon C va E ( 00100 | 10000 = 10100)
            // Is has C: (C | E) & C = 10100 & 00100 = 00100

            
            // 10100 mon C va E
            // 10100 >> 0 => 10100 & 1 = 00000 = 0
            // 10100 >> 1 => 10100 & 1 = 00000 = 0
            // 10100 >> 2 => 00101 & 1 = 00001 = 1
            // 10100 >> 3 => 00101 & 1 = 00001 = 1
            // 10100 >> 4 => 00001 & 1 = 00001 = 1
            // Calculate Main Item Price
            decimal MilkTeaPrice = 10_000M; // kiểu dữ liệu lưu trữ thập phân gồm : Decimal, double, float 
            int milkTea = 1 << 16 ;

            decimal olongTeaPrice = 20_000M;
            int olongTea = 1 << 17 ;

            //Tooping Item
            decimal cherryPrice = 6_000M;
            int cherry = 1 << 0 ;

            decimal flanPrice = 7_000m;
            int flan = 1 << 1 ;
            //
            decimal jellyPrice = 8_000m;
            int jelly = 1 << 2 ;

            decimal cheesePrice = 9_000m;
            int cheese = 1 << 3 ;

            int order1 = milkTea | cherry | cheese ;

            decimal totall = 0m;

            /*
            if ((order1 & milkTea) == milkTea) totall += MilkTeaPrice;
            if ((order1 & olongTea) == olongTea) totall += olongTeaPrice;

            if ((order1 & cherry) == cherry) totall += cherryPrice;
            if ((order1 & flan) == flan) totall += flanPrice;
            if ((order1 & jelly) == jelly) totall += jellyPrice;
            if ((order1 & cheese) == cheese) totall += cheesePrice;
            */

            for (int i = 0; i < 31; i++)
            {
                int temp = order1 & (1 << i);
                /*
                switch (temp)
                {
                    case int _ when temp == milkTea: totall += MilkTeaPrice; break;
                    case int _ when temp == olongTea: totall += olongTeaPrice; break;

                    case int _ when temp == cherry: totall += cherryPrice; break;
                    case int _ when temp == flan: totall += flanPrice; break;
                    case int _ when temp == jelly: totall += jellyPrice; break;
                    case int _ when temp == cheese: totall += cheesePrice; break;
                    default: totall += 0; break;
                }
                */
                totall += temp switch
                {
                    int _ when temp == milkTea => MilkTeaPrice,
                    int _ when temp == olongTea => olongTeaPrice,
                    int _ when temp == cherry => cherryPrice,
                    int _ when temp == flan => flanPrice,
                    int _ when temp == jelly => jellyPrice,
                    int _ when temp == cheese => cheesePrice,
                    _ => 0,
                };
            }
            

            Console.WriteLine($"Totall of order1 is $ { totall}");
         }
    }

  
}
