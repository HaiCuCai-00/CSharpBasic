using System;
using System.Linq;
namespace _06.Condition.SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //input month => out put number of days

            for (int i = 1; i <= 12; i++)
                FindNumberDaysEachMonth1(i);

            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
                FindNumberDaysEachMonth2(i);

            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
                FindNumberDaysEachMonth3(i);

            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
                FindNumberDaysEachMonth4(i);

            Console.WriteLine();

            var message1 = Test(("Manh", 18));
            Console.WriteLine(message1);

            var message2 = Test(("Ngoc", 30));
            Console.WriteLine(message2);

            var message3 = Test(("Han", 18));
            Console.WriteLine(message3);

            var message4 = Test(("Ha", 20));
            Console.WriteLine(message4);

            var message5 = Test(("Huy", 69));
            Console.WriteLine(message5);
            Console.WriteLine("\n\n\n\n\n\n");

            Console.ReadLine();
        }

        static void FindNumberDaysEachMonth1(int month)
        {
            string numberOfDays = string.Empty;

            if (month < 1 || month > 12)
                throw new Exception($"Month {month} is not valid");
            else if (month == 1 || month == 3 || month == 5 || month == 7 ||
                month == 8 || month == 10 || month == 12)
                numberOfDays = "31";
            else if (month == 2)
                numberOfDays = "28 or 29";
            else
                numberOfDays = "30";

            Console.WriteLine($"Month {month} has {numberOfDays} days");

        }

        static void FindNumberDaysEachMonth2(int month)
        {
            string numberOfDays = string.Empty;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: numberOfDays = "31"; break;
                case 2: numberOfDays = "28 or 29"; break;
                case 4:
                case 6:
                case 9:
                case 11: numberOfDays = "30"; break;
                default: throw new Exception($"Month {month} is not valid");
            }


            Console.WriteLine($"Month {month} has {numberOfDays} days");
        }

        static void FindNumberDaysEachMonth3(int month)
        {
            string numberOfDays = string.Empty;

            switch (month)
            {
                case 1 or 3 or 5 or 7 or 8 or 10 or 12: numberOfDays = "31"; break;
                case 2: numberOfDays = "28 or 29"; break;
                //case int i when i == 4 || i == 6 || i == 9 || i == 11: numberOfDays = "30"; break;
                case 4 or 6 or 9 or 11: numberOfDays = "30"; break;
                default: throw new Exception($"Month {month} is not valid");
            }

            Console.WriteLine($"Month {month} has {numberOfDays} days");
        }

        static void FindNumberDaysEachMonth4(int month)
        {
            string numberOfDays = month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => "31",
                2 => "28 or 29",
                4 or 6 or 9 or 11 => "30",
                _ => throw new Exception($"Month {month} is not valid")
            };

            Console.WriteLine($"Month {month} has {numberOfDays} days");
        }

        static string Test((string, int) profile)
            => profile switch
            {
                ("Manh", 18) => "Manh is 18 year old",
                ("Ngoc", _) => "Manh loves Ngoc",
                ("Han", _) => "He will marry her",
                (_, 20) => "Manh will be 20 after two years",
                (_, _) => "I do not know about him",
            };
    }
}
