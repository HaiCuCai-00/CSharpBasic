using System;

namespace _62.JaggedArray.Basic.Exercise.MikTea
{
    class Program
    {
        /*
        * Main Item
        * - Milk Tea: 10.000
        * - Olong Tea: 20.000
        * 
        * Topping Item:
        * 0201 Cherry: 6.000
        * 0202 Flan : 7.000
        * 0203 Jelly: 8.000
        * 0204 Cheese: 9.000
        */
        static void Main(string[] args)
        {
            var list = new (string name, int price)[][]
            {
                new [] { ("Milk Tea", 10_000), //1
                         ("Olong Tea", 20_000) //111
                       },
                new [] { ("Cherry", 6_000), //1
                         ("Plan", 7_000),   //2
                         ("Jelly", 8_000), //3
                         ("Cheese", 9_000)  //4
                        }
            };

            string oderItem = "0103"; //0101 => 01 01
            //0101 => row: 01 and item: 01 
            //0111 => row: 01 and item: 111;
            //0103 => row:02 and item: 04 
            Console.WriteLine(oderItem[..2]);
            Console.WriteLine(int.Parse(oderItem[..2]));
            Console.WriteLine(oderItem[2..]);
            Console.WriteLine(int.Parse(oderItem[2..]));
            Console.WriteLine("------------------------");

            var item = list[int.Parse(oderItem[..2])][int.Parse(oderItem[2..])];
            Console.WriteLine($"{ item.Item1} - {item.Item2 }");
            Console.WriteLine("-----------------------");

            var saleOrder = new[] { "0000", "0100", "0103" };
            var total = 0;

            foreach (var orderLine in saleOrder)
            {
                if (string.IsNullOrEmpty(orderLine) || orderLine.Length < 4)
                {
                    throw new Exception($"Item id is not imvaid");
                }

                var temp = list[int.Parse(orderLine[..2])][int.Parse(orderLine[2..])];
                total += temp.price;
                Console.WriteLine($"Order: {temp.name} - {temp.price}");
                Console.WriteLine($"Total: {total}");
            }
        }
    }
}
