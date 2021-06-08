using System;

namespace _06.Condition.SwitchCase // giải quyết trường hợp if else nhiều quá 
{
    class Program
    {
        static void Main(string[] args)
        {
            // input month => out put number of days
            for (int i = 1; i <= 12; i++)
            {
                FindNumberDaysOfMonth1(i);
            }

            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
            {
                FindNumberDaysOfMonth2(i);
            }


            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
            {
                FindNumberDayOfMonth3(i);
            }

            Console.WriteLine("Hello World!");

            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
            {
                FindNumberDayOfMonth4(i);
            }

            Console.WriteLine();
            var messagel = Test(("Manh", 18));
            Console.WriteLine(messagel);

            Console.WriteLine();
            var messagle = Test(("Ngoc", 20));
            Console.WriteLine(messagle);

            Console.WriteLine();
            var messagle1 = Test(("Han", 22));
            Console.WriteLine(messagle1);

            Console.WriteLine();


            Console.WriteLine();

        }

        static void FindNumberDaysOfMonth1(int month)
        {
            string days = string.Empty;

            if ((month < 1 || month > 12))
                throw new Exception($"Month {month} is not valid");
            else if (month == 1 || month == 3 || month == 5 ||
               month == 7 || month == 8 || month == 10 || month == 12)
                days = "31";
            else if (month == 2)
                days = "28 or 29";
            else
                days = "30";

            Console.WriteLine($"Month {month} has {days} days");

        }

        static void FindNumberDaysOfMonth2(int month)
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

        static void FindNumberDayOfMonth3(int month)
        {
            string numberOfDay = string.Empty;

            switch (month)
            {
                case 1 or 3 or 5 or 7 or 8 or 10 or 12: numberOfDay = "31"; break;
                case 2: numberOfDay = "28 or 29"; break;
                case 4 or 6 or 9 or 11: numberOfDay = "30"; break;
                default: throw new Exception($"Month {month} is not valid");
            }
            Console.WriteLine($"Month {month} has {numberOfDay} days");
        }

        static void FindNumberDayOfMonth4(int month)
        {
            string numberOfDays = month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => "31",
                2 => "28 or 29",
                4 or 6 or 9 or 11 => "30",
                // _ thay thế default và đưa dấu ; sau dấu }
                _ => throw new Exception($"Month {month} is not valid")
            };
            Console.WriteLine($"Month {month} has {numberOfDays} days");
        }

        static string Test((string, int) profile)
        {
            var message = profile switch
            {
                ("Manh", 18) => "Manh is 18 year old",
                ("Ngoc", _) => "Manh loves Ngoc",
                ("Han", _) => " He will marry her",
                (_, 20) => "Manh will be 20 after two years",
                (_, _) => "I do not know about him",
            };
            return message;
        }

        static string Test2((string, int) profile)
           => profile switch
            {
                ("Manh", 18) => "Manh is 18 year old",
                ("Ngoc", _) => "Manh loves Ngoc",
                ("Han", _) => " He will marry her",
                (_, 20) => "Manh will be 20 after two years",
                (_, _) => "I do not know about him",
            };
      
       
    }
}
