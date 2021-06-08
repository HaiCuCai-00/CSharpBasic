using System;

namespace _61.JaggedArray.Basic.Exercise.Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new string[10][]
            {
                new []{"apple", "axe", "arrow", "ant", "anchor", "alligator"},
                new []{"boy", "balloon", "bus", "butterfly", "bell", "ball"},
                new []{"car", "cow", "cheery", "computer"},
                new []{"dragon", "dophin", "donkey", "drum", "dog"},
                new []{"elephant", "egg", "evenlope", "eat"},
                new []{"fox", "flash", "five"},
                new []{"girl", "green", "goose", "grapre"},
                new []{"hen", "hat", "home", "house"},
                new []{"Iron", "ice cream", "internet", "icloud"},
                new []{"jar", "jam", "jug", "jump", "juice"},
            };

            string word = "apple";
            Console.WriteLine( word[0] - 97);  // a => 0 => dict [0]
            Console.WriteLine(dict[word[0] - 97][0]);
            Console.WriteLine(dict[word[0] - 97][01]);
            Console.WriteLine(dict[word[0] - 97][02]);

        }
    }
}
