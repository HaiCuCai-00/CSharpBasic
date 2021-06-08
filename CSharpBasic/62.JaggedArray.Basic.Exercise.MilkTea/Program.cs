using System;

namespace _62.JaggedArray.Basic.Exercise.MilkTea
{
    class Program
    {
        /*
         * Main Item:
         * 0101: Milk Tea : 10.000
         * 0102: Olong Tea: 20.000
         *
         * Topping Item:
         * 0201: Cherry: 6.000
         * 0202: Plan  : 7.000
         * 0203: Jelly : 8.000
         * 0204: Cheese: 9.000  
         */

        static void Main(string[] args)
        {
            var list = new (string name, int price)[][]
            {
                //00
                new [] {
                    ("Milk Tea", 10_000),//00
                    ("Olong Tea", 20_000)//01
                },
                //01
                new [] {
                    ("Cherry", 6_000), //00
                    ("Plan", 6_000),   //01
                    ("Jelly", 8_000),  //02
                    ("Cheese", 9_000)  //03
                }
            };
            string orderItem = "0001";
            //0101  => row:01 and item 01  => ("Milk Tea", 10_000)
            //01111 => row:01 and item:111 => Unknow
            //0204  => row:02 and item:04  => ("Cheese", 9_000) 
            Console.WriteLine(orderItem[..2]);
            Console.WriteLine(int.Parse(orderItem[..2]));
            Console.WriteLine(orderItem[2..]);
            Console.WriteLine(int.Parse(orderItem[2..]));
            Console.WriteLine("--------------------------------");

            var item = list[int.Parse(orderItem[..2])][int.Parse(orderItem[2..])];
            Console.WriteLine($"{item.name} - {item.price}");
            Console.WriteLine("--------------------------------");

            var saleOrder = new[] { "0000", "0100", "0103" };
            var total = 0;

            foreach (var orderLine in saleOrder)
            {
                if (string.IsNullOrEmpty(orderLine) || orderLine.Length < 4)
                    throw new Exception("Order Line is not valid");
        
                var temp = list[int.Parse(orderLine[..2])][int.Parse(orderLine[2..])];
                total += temp.price;
                Console.WriteLine($"Order: {temp.name} - {temp.price}");
            }
            Console.WriteLine($"Total: {total}");
        }
    }
}
