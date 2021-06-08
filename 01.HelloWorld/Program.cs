using System;

namespace _01.HelloWorld
{
    class Program
    {
        //svm
        static void Main(string[] args)
        {
            //[Type][Vảiable] = [Value]
            string name = "Hai";
            String greeting = "Hello";

            //Concatenation(bad)
            String messagel1 = greeting + " " + name;
            Console.WriteLine(messagel1);

            //Place Holder(medium)
            // Đăt chỗ 
            String messagel2 = string.Format("{0} {1}", greeting /*{0}*/, name/*{1}*/);
            Console.WriteLine(messagel2);
            Console.WriteLine("{0} {1}", greeting, name); // kiểu đặt chỗ 

            //Interpolastion (best)
            String messagel3 = $"{ greeting } { name }";
            Console.WriteLine(messagel3);

            Console.ReadLine(); // Waiting for user input
        }  
        //Imperative Style vs Declarative Style
    }

}
