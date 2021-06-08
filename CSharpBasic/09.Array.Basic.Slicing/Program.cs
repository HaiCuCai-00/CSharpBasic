using System;

namespace _09.Array.Basic.Slicing
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] fruits = new[] { 
                //0       1         2         3        4              5         6      7 (Length)
                "Apple", "Banana", "Orange", "Mango", "Water Melon", "Cherry", "Kiwi"
                //^7      ^6        ^5        ^4       ^3             ^2        ^1     ^0 (Length)
            };

            PrintArray(fruits[..]);     //Print all items
            PrintArray(fruits[0..7]);   //Print all items
            PrintArray(fruits[^7..^0]); //Print all items
            PrintArray(fruits[0..]);    //Print all items
            PrintArray(fruits[^7..]);   //Print all items
            PrintArray(fruits[..7]);    //Print all items
            PrintArray(fruits[..^0]);   //Print all items
            Console.WriteLine();

            PrintArray(fruits[3]);      //Print item at position 3
            PrintArray(fruits[^4]);     //Print item at position 3
            Console.WriteLine();

            PrintArray(fruits[1..5]);   //Print items at position 1, 2, 3, 4
            PrintArray(fruits[^6..^2]); //Print items at position 1, 2, 3, 4
            PrintArray(fruits[1..^2]);  //Print items at position 1, 2, 3, 4
            PrintArray(fruits[^6..5]);  //Print items at position 1, 2, 3, 4
            Console.WriteLine();

            Index i1 = 5;
            PrintArray(fruits[i1]);
            Index i2 = ^2;
            PrintArray(fruits[i2]);
            Console.WriteLine();

            Range r1 = 5..7;
            PrintArray(fruits[r1]);
            Range r2 = ^2..^0;
            PrintArray(fruits[r2]);
            Console.WriteLine();

            var index = System.Array.IndexOf(fruits, "Mango");
            Console.WriteLine(index > -1 ? $"Mango is at position {index}": "Mango not found");
        }

        static void PrintArray(params string[] arr)
            => Console.WriteLine(string.Join(", ", arr));

    }
}
