using System;

namespace _61.JaggedArray.Basic.Exercise.Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new string[10][]
            {
                new []{ "apple", "axe", "arrow", "ant", "anchor", "alligator"},
                new []{ "boy", "balloon", "bus", "butterfly", "bell", "ball"},
                new []{ "cat", "car", "cow", "cherry", "computer"},
                new []{ "dragon", "dolphin", "donkey", "drum", "dog", "donut"},
                new []{ "egg", "elephant", "envelop", "eggplant", "eight", "eat", "environment"},
                new []{ "fox", "fish", "flower", "family", "five"},
                new []{ "girl", "grape", "graph", "goose", "glassed", "green"},
                new []{ "hen", "hat", "hammer", "home", "house"},
                new []{ "iron", "ice cream", "internet", "information"},
                new []{ "jar", "jam", "jug", "jump", "juice"}
            };

            string word = "apple";       
            Console.WriteLine(word[0] - 97); //a => 0 => dict[0]
            Console.WriteLine(dict[word[0] - 97][0]);
            Console.WriteLine(dict[word[0] - 97][1]);
            Console.WriteLine(dict[word[0] - 97][2]);
            Console.WriteLine("--------------------------------");

            word = "banana";
            Console.WriteLine(word[0] - 97); //b => 1 => dict[1]
            Console.WriteLine(dict[word[0] - 97][0]); //dict[1][0]
            Console.WriteLine(dict[word[0] - 97][1]);
            Console.WriteLine(dict[word[0] - 97][2]);
            Console.WriteLine("--------------------------------");

            var dict2 = new[] { "jar", "jam", "jug", "jump", "juice" };
            Console.WriteLine(Array.IndexOf(dict2, "jar"));
            Console.WriteLine(Array.IndexOf(dict2, "Hello"));
            //IndexOf => -1: Not Found; >= 0: Found

            bool hasItem = false;
            foreach (var item in dict2)
            {
                if (item == "jump")
                { 
                    hasItem = true; 
                    break; 
                }
            }
            Console.WriteLine(hasItem ? $"dict2 has \"jump\"": "not found");
            Console.WriteLine("--------------------------------");

            do
            {
                Console.Write("Please input one word: ");
                string input = Console.ReadLine();

                if(string.IsNullOrEmpty(input.Trim()))
                {
                    Console.WriteLine("Word is required!");
                    continue;
                }

                if(input[0] < 'a' || input[0] > 'k')
                {
                    Console.WriteLine("Word must start with letter from 'a' to 'j'!");
                    continue;
                }

                int index = Array.IndexOf(dict[input[0] - 97], input);
                if(index == -1)
                    Console.WriteLine($"'{input}' not found");
                else
                    Console.WriteLine($"Dictionary has '{input}' at [{input[0] - 97}][{index}]");

                Console.Write("Do you want to exit (press y): ");
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && char.ToLower(input[0]) == 'y')
                    break;

            } while (true);

            Console.WriteLine("Have a good day!");
        }
    }
}
