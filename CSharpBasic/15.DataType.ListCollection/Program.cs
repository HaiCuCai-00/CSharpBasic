using System;
using System.Collections.Generic;

namespace _15.DataType.ListCollection
{
    class Program
    {
        //List Collection C# Built-in
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            numbers.Add(9);
            numbers.Add(10);
            numbers.Remove(6);

            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine();

            numbers.Add(-1);
            numbers.AddRange(new[] { -2, -3 });

            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine();

            numbers.Sort();
            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine(numbers.Count);
        }


        //List Collection C# Built by Me
        static void Main(string[] args)
        {
            MyList list = new MyList();

            list.Add(1);
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Remove(10);

          
            Console.WriteLine($"Count: {list.Count}");
            foreach (var item in list.Get())
            {
                Console.Write($"{item} ");
            }
        }
    }

    class MyList
    {
        //fields
        private int[] array;
        private int size = 5;
        private int position = -1;

        //properties
        public int Count { get { return position + 1; } }

        //constructors
        public  MyList()
        {
            array = new int[size];
        }

        //Methods
        public void Add(int item)
        {
            if(Count == size)
            {
                size *= 2;

                var oldArray = array;

                array = new int[size];

                for (int i = 0; i < Count; i++)
                    array[i] = oldArray[i];
            }
            array[++position] = item;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if(array[i] == item)
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }                 
                    position--;
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<int> Get()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            };
        }
    }

    //[0, 2, 2, 4, 4, 5, 5, 8, , , , , , , , , , ]
    //                      ^
    //                   position = 7
    //[0, 2, 2, 4, 4, 5, 5, 8, 9, , , , , , , , , ]
    //                         ^
    //                     position = 8
    //[ , , , , , , , , , , , , , , , , , , , , , ]
    //
    //position = -1

    //[1, 2, 3, 4, 5, 6, 7, 8]
    //                ^
    //              Remove
    //Step 1:
    //[1, 2, 3, 4, 5, BUMP, 7, 8]
    //                         ^
    //                      position = 7
    //Step 2:
    //[1, 2, 3, 4, 5, 7, 8, 8]
    //                   ^
    //                position = 6
}
