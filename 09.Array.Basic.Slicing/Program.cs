using System;

namespace _09.Array.Basic.Slicing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new[] 
            {
             // 0   ,   1      ,  2      ,  3             4 ,            5     ,    6        7[Lenght]
              "Apple", "Banana", "Orange", "Mango",  "Water Melon", "Cherry", " Kiwi"
             // ^7   ,    ^6,     ^5,       ^4,         ^3,           ^2,        ^1         ^0
            };
            PrintArray(fruit[..]);  // Print all items
            PrintArray(fruit[0..7]);
            PrintArray(fruit[^7..^0]);
            PrintArray(fruit[0..]);
            PrintArray(fruit[..7]);
            PrintArray(fruit[..^0]);
            Console.WriteLine();

            PrintArray(fruit[3]);   // Print item at position 3
            PrintArray(fruit[^4]);  // Print item at position 3
            Console.WriteLine();

            PrintArray(fruit[1..5]); //Print item at position 1, 2, 3, 4
            PrintArray(fruit[^6..^2]);
            PrintArray(fruit[1..^2]);
            PrintArray(fruit[^6..5]);

            Index i1 = 5;
            PrintArray(fruit[i1]);

            Index i2 = ^2;
            PrintArray(fruit[i2]);

            Range r1 = 5..7;
            PrintArray(fruit[r1]);
            Range r2 = ^2..^0;
            PrintArray(fruit[r2]);

            var index = System.Array.IndexOf(fruit, "Mango");
            Console.WriteLine(index > -1 ?$"Mango is at postion {index}" : "Mango not foud" ); // Thay cho câu lệnh if else 
        }
        static void PrintArray(params String[] arr)
            => Console.WriteLine(string.Join(",", arr));

    }
}
