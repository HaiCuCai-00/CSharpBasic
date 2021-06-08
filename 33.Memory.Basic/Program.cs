using System;

namespace _33.Memory.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Value Type : struct, enum, tuple
             * Reference Type: Class, delegate, interface
             * 
             */
            // int a = 10;               // value type
            // bool b = true;            // value type
            //string name = "Manh";      // Referen type

            int[] numbers = new[] { 1, 2, 3, 4 }; // Referen type
            var number2 = Array.CreateInstance(typeof(int), 4);
            number2.SetValue(1, 0);
            number2.SetValue(2, 1);
            number2.SetValue(3, 2);
            number2.SetValue(4, 5);

        }
    }
}
