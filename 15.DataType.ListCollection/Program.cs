using System;
using System.Collections.Generic;

namespace _15.DataType.ListCollection
{
    class Program
    {
       //List collection c# built - in
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            numbers.Add(9);
            numbers.Add(10);
            numbers.Add(0);

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

        //List collection c# built by me
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
        }
    }

    class MyList
    {
        
        private int position = -1;
        private int[] array;
        private int size = 5;

        //Constructor
        public MyList()
        {
            array = new int[size];
        }

        //Methoods
        public void Add(int item)
        {
            if (Count == size)
            {

            }
            array[++position] = item;
        }
    }

    // 

}
