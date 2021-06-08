using System;

namespace _51.Condition.IfElse.Exercise.MilkTea
{
    class Program
    {
        static void TestVersion1()
        {
            /*
             * Main Item:
             * - Milk Tea : 10.000
             * - Olong Tea: 20.000
             *
             * Topping Item:
             * - Cherry: 6.000
             * - Plan  : 7.000
             * - Jelly : 8.000
             * - Cheese: 9.000  
             */

            //32 bit = 16bit(main item) - 16bit(topping)

            //Main Item
            decimal milkTeaPrice = 10_000m;
            int milkTea = 0b0000_0000_0000_0001_0000_0000_0000_0000;

            decimal olongTeaPrice = 20_000m;
            int olongTea = 0b0000_0000_0000_0010_0000_0000_0000_0000;

            //Topping Item
            decimal cherryPrice = 6_000m;
            int cherry = 0b0000_0000_0000_0000_0000_0000_0000_0001;

            decimal planPrice = 7_000m;
            int plan = 0b0000_0000_0000_0000_0000_0000_0000_0010;

            decimal jellyPrice = 8_000m;
            int jelly = 0b0000_0000_0000_0000_0000_0000_0000_0100;

            decimal cheesePrice = 9_000m;
            int cheese = 0b0000_0000_0000_0000_0000_0000_0000_1000;

            int order1 = milkTea | cherry | cheese;
            Console.WriteLine($"Order 1: { Convert.ToString(order1, 2) }");

            int order2 = olongTea | plan | jelly;
            Console.WriteLine($"Order 2 { Convert.ToString(order2, 2)}");

            //00001 mon A
            //00010 mon B
            //00100 mon C
            //01000 mon D
            //10000 mon E

            //10100 mon C va E

            //10100 >> 0 => 10100 & 1 = 00000 = 0
            //10100 >> 1 => 01010 & 1 = 00000 = 0
            //10100 >> 2 => 00101 & 1 = 00001 = 1
            //10100 >> 3 => 00010 & 1 = 00000 = 0
            //10100 >> 4 => 00001 & 1 = 00001 = 1

            decimal total1 = 0m;
            //Calculate Main Item Price
            if ((order1 >> 16 & 1) == 1) total1 += milkTeaPrice;
            if ((order1 >> 17 & 1) == 1) total1 += olongTeaPrice;

            //Calculate Topping Price
            if ((order1 >> 0 & 1) == 1) total1 += cherryPrice;
            if ((order1 >> 1 & 1) == 1) total1 += planPrice;
            if ((order1 >> 2 & 1) == 1) total1 += jellyPrice;
            if ((order1 >> 3 & 1) == 1) total1 += cheesePrice;

            Console.WriteLine($"Total of order 1 is ${total1}");
        }

        static void TestVersion2()
        {
            //Main Item
            decimal milkTeaPrice = 10_000m;
            int milkTea = 1 << 16;

            decimal olongTeaPrice = 20_000m;
            int olongTea = 1 << 17;

            //Topping Item
            decimal cherryPrice = 6_000m;
            int cherry = 1 << 0;

            decimal planPrice = 7_000m;
            int plan = 1 << 1;

            decimal jellyPrice = 8_000m;
            int jelly = 1 << 2;

            decimal cheesePrice = 9_000m;
            int cheese = 1 << 3;

            int order1 = milkTea | cherry | cheese;
            decimal total1 = 0m;

            //00001 mon A
            //00010 mon B
            //00100 mon C
            //01000 mon D
            //10000 mon E

            //Order C and E (C | E)     = 00100 | 10000 = 10100
            //Is Has C:     (C | E) & C = 10100 & 00100 = 00100 (C)
            //Is Has E:     (C | E) & E = 10100 & 10000 = 10000 (E)
            //Is Has A:     (C | E) & A = 10100 & 00001 = 00000 (?)

            ////Calculate Main Item Price
            //if ((order1 & milkTea) == milkTea) total1 += milkTeaPrice;
            //if ((order1 & olongTea) == olongTea) total1 += olongTeaPrice;

            ////Calculate Topping Price
            //if ((order1 & cherry) == cherry) total1 += cherryPrice;
            //if ((order1 & plan) == plan) total1 += planPrice;
            //if ((order1 & jelly) == jelly) total1 += jellyPrice;
            //if ((order1 & cheese) == cheese) total1 += cheesePrice;

            for (int i = 0; i < 31; i++)
            {
                int temp = order1 & (1 << i);

                total1 += temp switch
                {
                    int _ when temp == milkTea => milkTeaPrice,
                    int _ when temp == olongTea => olongTeaPrice,
                    int _ when temp == cherry => cherryPrice,
                    int _ when temp == plan => planPrice,
                    int _ when temp == jelly => jellyPrice,
                    int _ when temp == cheese => cheesePrice,
                    _ => 0,
                };
            }
            Console.WriteLine($"Total of order 1 is ${total1}");
        }

        static void Main(string[] args)
        {
            TestVersion2();
        }
    }
}
