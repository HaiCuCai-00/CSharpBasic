using System;
using System.IO;
using System.Text;

namespace _02.Data_TypeBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //LearnBoolType();

            //LearnInt();

            //oddeven();

            // DoExercise2();

            LearnCharType();
            Console.ReadLine();
        }

        private static void DoExercise2()
        {
            int month = 12;
            if (month > 0 && month < 13)
            {
                if (month < 7)
                {
                    Console.WriteLine(((month) < 4) && ((month) < 7) ? $"{month} Q1" : $"{month} Q2");
                }
                else
                {
                    Console.WriteLine(((month) > 7) && ((month) > 10) ? $"{month} Q4" : $"{month} Q3");
                }
            }
            else
            {
                Console.WriteLine("Thang khong hop le");
            }
        }

        private static void oddeven()
        {
            int number = 13;
            //+, -, /, %(mod)
            // 4 mod 3 =1 
            if (number % 2 == 0)
                Console.WriteLine($"{number} is even number");
            else
                Console.WriteLine($"{number} is odd number");

            // |, &, ^, >>, <<
            if ((number & 1) == 0)
                Console.WriteLine($"{number} is even number");
            else
                Console.WriteLine($"{number} is odd number");
            Console.WriteLine((number & 1) == 0 ? $"{number} is even number" : $"{number} is oddeven number");
            Console.WriteLine($"{number} is {((number & 1) == 0 ? "even":"odd ")} number ");
        }

        private static void LearnInt()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

            int d = 0b1100;
            int e = 0b1;
            int f = d + e;
            Console.WriteLine($"{d} + {e} = {f}");

            int g = 0xA;
            int h = 0xB;
            int i = g + h;
            Console.WriteLine($"{g} + {h} = {i}");

            int j = 16;         //Decimal
            int k = 0b1_0000;   //Binary
            int l = 0x10;       //HEX
            Console.WriteLine($" j == k ({j == k})");
            Console.WriteLine($" l == k ({k == l})");
            Console.WriteLine($" l == j ({l == j})");

            //------------Positive or Negative Number------

            //int m = -10 ; // int => positive or negative number
            //uint n = 10; // unsigned int, only positive number (chỉ chứa số dương )


            //------------Number Ranger Limitation-----------
            // Search Google: C# built in type

            /* 8 bit: byte
             * byte => positive number
             * sbyte => positive or negatice number
             * 
             * 16bit
             * ushort =>positive number
             * short => positive or negatice number
             * 
             * 32bit
             * unit => positive number
             * int => positive or negatice number
             * 
             * 64bit
             * long => positive number
             * ulong => positive or negatice number
             */

            //-----------C# Keywork type----------
            //int o = 5;
            //INT32 p = 5;


            //long => press F12 or hover mouse on this type to find origin data type


            //-----------------C#  : type suffixes-----------------
            //Search Google: C#

            // int u = 8 ; //u : int32(int), 8:int32(int) => no implicit cast: u =8;
            // long v = 8 ; // v int64(long), 8:int32(int) => implicit cast: v = (int64)8;

            // Seach Google: C# type suffixes
            //long w = 8l; // w:Int64(long), 8L: Int64(long) =. no implicit casy: w = 8;

            //--------------------Divide in Integer Type----------------
            decimal x = 10m;
            Console.WriteLine($"IN Decimal Type: 10/3 = {x / 3}");
            int y = 10;
            Console.WriteLine($"In Integer Type: 10 / 3 = { y / 3}");
            // Interger type only contain integer part. Decimal part will be removed

        }

        //[sattic|Optional] [Type] [Name]([Parameter1], [Parameter2])
        //[Name] = Verb + Noun
        /*
         * [Type] = void
         * [Name] = LearnBoolType
         * ([Parameter1],  [Parameter2], ...) = ()
         *
         *
         */
        static void LearnBoolType()
        {
            //true => male; false => female
            // bool : boolean
            bool gender = false;

            if (gender == true)// smell code
            {
                //on success
                Console.WriteLine("I am Male");
            }
            else
            {
                //on failure
                Console.WriteLine("My gender is female");
            }

            bool hasHouse = true;
            if (hasHouse) //hasHouse == true
            {
                Console.WriteLine("I have a house");
            }

            bool hasCar = false;
            if (!hasCar)// hasCar == false
            {
                Console.WriteLine("I don't have a car");
            }

            bool hasMoney = false;
            Console.WriteLine( hasMoney ? "I am rich person" : "I am poor person");
            Console.WriteLine("Hello World!");
        }

        static void LearnCharType()
        {
            char c1 = 'a';
            Console.WriteLine(c1);

            //-----Unicode-----------
            // Seach Google: Unicode Character
            char c3 = '\u058D';
            Console.WriteLine(c3);

            File.WriteAllText("D:\\.NET_LopAnnhManh\\Test.txt", c3.ToString(), Encoding.Unicode);

            File.WriteAllText(@"D:\.NET_LopAnnhManh\Test.txt", c3.ToString(), Encoding.Unicode);

            ushort s1 = 0x0061; // integer
            char c4 = (char)s1;
            Console.WriteLine(c4);

            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i);
                Console.WriteLine();
            }

            ushort s2 = 97; // postive integer
            char c5 = (char)s2; //char
            Console.WriteLine(c5);

            ushort s3 = 0b0110_0001;
            char c6 = (char)s3;
            Console.WriteLine(c6);

            string name = "Manh";
            // ['M' ,'A' ,'N' 'H']
            //   0    1    2   3
            //name[1] => return 'A'
            //Length = 4
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            string nick = "Trang";
            foreach (var x in nick)
            {
                Console.WriteLine(x);
            }
        }

    }
}
