using System;

namespace _54.Array.Basic.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new[] { 
                "January", "February", "March",
                "April", "May", "June",
                "July", "August", "September",
                "October", "November", "December"};
            do
            {
                Console.Write("Please input number from (1~12):"); ;
                string input = Console.ReadLine();

               // if (input.Trim('s') == "")
               //     Console.WriteLine("Number is required");

                if (string.IsNullOrEmpty(input.Trim()))
                {
                    Console.WriteLine("Number is required");
                    continue;
                }

                //int number;
                //bool parseReult = int.TryParse(input, out number);
                //if(!parseReult)
                //    Console.WriteLine("Month must be number");

                if (!int.TryParse(input, out int number )) 
                {
                    Console.WriteLine("Month must be number");
                    continue;
                }

                // A = number >= 1
                // B = number <= 12
                // ! (A and B) = !A or !B
                //
                // !(number >=1 && number <12) = !(A and B)
                //
                // !A = number < 1
                // !B = number > 12
                // !A or !B = number < 1 or number > 12 = number <1 || number > 12 = number < 1 || number > 12 
                if (number < 1 || number > 12)
                {
                    Console.WriteLine("Month must be number");
                    continue;
                }
                Console.WriteLine($"Month {months[number - 1]}");
                Console.Write("Do you want to exit (press y)?");
                input = Console.ReadLine();

                if (input.Trim().ToLower() == "y")
                    break;
               
            } while (true);
        }
    }
}
