using System;

namespace _55.Arry.Basic.Exercise.Zodiacs
{
    class Program
    {
        static void Main(string[] args)
        {
            var Zodiacs = new[]
            {
                 "Monkey",
                "Chicken",
                "Dog",
                "Pig",
                "Mouse",
                "Buffalo",
                "Tiger",
                "Cat",
                "Dragon",
                "Snake",
                "Horse",
                "Goat"
            };
            Console.WriteLine(Zodiacs[1992 % 12]);
            Console.WriteLine(Zodiacs[2021 % 12]);
        }
    }
}
