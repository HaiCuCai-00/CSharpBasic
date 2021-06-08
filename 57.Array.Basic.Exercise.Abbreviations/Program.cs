using System;

namespace _57.Array.Basic.Exercise.Abbreviations
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "nguyen hung manh Dep Zai";

            var parts = name.Split(' ');

            foreach (var item in parts)
                Console.Write(char.ToUpper(item[0]));
            
        }
    }
}
