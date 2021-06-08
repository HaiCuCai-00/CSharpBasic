using System;

namespace _01.HelloWorld
{
    class Program
    {
        //svm
        static void Main(string[] args)
        {

            //[Type] [Variable] = [Value]
            string name = "Manh";
            string greeting = "Hello";

            //Concatenation (Bad)
            string message1 = greeting + " " + name;
            Console.WriteLine(message1);

            //Place Holder (Medium)
            string message2 = string.Format("{0} {1}", greeting /*{0}*/, name /*{1}*/);
            Console.WriteLine(message2);

            Console.WriteLine("{0} {1}", greeting, name);

            //Interpolation (Best)
            string message4 = $"{greeting} {name}";
            Console.WriteLine(message4);

            Console.ReadLine(); //Waiting for user input
        }

        //Imperative Style vs Declarative Style
    }
}
