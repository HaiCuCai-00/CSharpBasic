using System;

namespace _55.Array.Basic.Exercise.Zodiacs
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodiacs = new[]
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

            Console.WriteLine(zodiacs[1992 % 12]);

        }
    }
}
