using System;
using System.IO;
using System.Text;

namespace _02.DataType.Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            //LearnBoolType();
            //LearnIntegerType();
            LearnCharType();

            //DoExercise1();

            Console.ReadLine();
        }

        static void LearnBoolType()
        {
            //true => male, false => female
            //bool: Boolean

            bool gender = false;

            // condition
            if (gender == true)// smell code
            {
                //on success
                Console.WriteLine("My gender is Male");
            }
            else
            {
                //on failure
                Console.WriteLine("My gender is Female");
            }

            bool hasHouse = true;

            if (hasHouse) //hasHouse == true
            {
                Console.WriteLine("I have a house");
            }

            bool hasCar = false;

            if (!hasCar) //hasCar == false
            {
                Console.WriteLine("I don't have a car");
            }

            bool hasMoney = true;
            Console.WriteLine(hasMoney ? "I am rich person" : "I am poor person");//ternary
            Console.WriteLine();
        }

        static void LearnIntegerType()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

            int d = 0b1100;//12
            int e = 0b1;   //1
            int f = d + e;
            Console.WriteLine($"{d} + {e} = {f}");//13

            int g = 0xA;//10
            int h = 0xB;//11
            int i = g + h;
            Console.WriteLine($"{g} + {h} = {i}");//21

            int j = 16;      //Decimal
            int k = 0b1_0000;//Binary
            int l = 0x10;    //Hex
            Console.WriteLine($"j == k ({j == k})");
            Console.WriteLine($"k == l ({k == l})");
            Console.WriteLine($"l == j ({l == j})");

            // ----------------------------------Positive Or Negative Number----------------------------------
            //int  m = -10;  //OK    //int  => positive or negative number
            //int  m =  10;  //OK    //int  => positive or negative number 
            //uint n = -10;  //Error //uint => Unsigned int, only positive number
            //uint n =  10;  //OK    //uint => Unsigned int, only positive number

            // ----------------------------------Number Range Limitation----------------------------------
            //Search Google: C# Built-in type
            /* 8 bit:  
             * byte   => positive number
             * sbyte  => positive or negatice number
             *
             * 16 bit:
             * ushort => positive number
             * short  => positive or negatice number
             * 
             * 32 bit:                        
             * uint   => positive number
             * int    => positive or negatice number
             * 
             * 64 bit
             * ulong  => positive number
             * long   => positive or negatice number
             */

            //----------------------------------C# Keywork Type----------------------------------
            //long => press F12 or hover mouse on this type to find origin data type

            //int o = 5;    
            //Int32 p = 5;  
            //int == Int32

            //long s = 5;
            //Int64 t = 5;
            //long == Int64

            //----------------------------------C# Type Suffixes----------------------------------
            //Search Google: c# type suffixes

            //int  u = 8;  //u:Int32(int) , 8:Int32(int)   => no implicit cast: u = 8;
            //long v = 8;  //v:Int64(long), 8:Int32(int)   =>    implicit cast: v = (Int64)8;
            //long w = 8L; //w:Int64(long), 8L:Int64(long) => no implicit cast: w = 8;

            //----------------------------------Divide in Integer Type----------------------------------
            decimal x = 10m;
            Console.WriteLine($"In Decimal Type: 10 / 3 = {x / 3}");
            int y = 10;
            Console.WriteLine($"In Integer Type: 10 / 3 = { y / 3 }");
            //Integer Type only contains integer part. Decimal part will be removed
        }

        static void LearnCharType()
        {
            char c1 = 'a';
            Console.WriteLine(c1);

            // ----------------------------------Unicode----------------------------------
            //Search Google: Unicode Character
            char c2 = '\u0061';
            Console.WriteLine(c2);

            char c3 = '\u058D';
            Console.WriteLine(c3);

            ushort s1 = 0x61;   //positive integer
            char c4 = (char)s1; //char
            Console.WriteLine(c4);

            ushort s2 = 97;    //positive integer
            char c5 = (char)s2;//char
            Console.WriteLine(c5);

            ushort s3 = 0b0110_0001;
            char c6 = (char)s3;
            Console.WriteLine((char)s3);

            File.WriteAllText("D:\\Text1.txt", c3.ToString(), Encoding.Unicode);
            File.WriteAllText(@"D:\Text2.txt", c3.ToString(), Encoding.Unicode);

            for (char i = 'a'; i <= 'z'; i++)
                Console.Write(i);

            Console.WriteLine();
            for (int i = 97; i <= 122; i++)
                Console.Write((char)i);

            Console.WriteLine();
            for (int i = 0x61; i <= 0x7A; i++)
                Console.Write((char)i);

            Console.WriteLine();
            for (int i = 0b0110_0001; i <= 0b0111_1010; i++)
                Console.Write((char)i);

            Console.WriteLine();

            string name = "Manh"; 
            //['M', 'A', 'N', 'H']
            //  0    1    2    3
            //name[1] => return 'A'
            //Length = 4
            for (int i = 0; i < name.Length; i++)
                Console.WriteLine(name[i]);

            string nick = "Trang";
            foreach (var x in nick)
                Console.WriteLine(x);
        }

        static void DoExercise1()
        {

            //+, -, *, /, % (mod)
            //4 mod 3 = 1

            int number = 13;

            if (number % 2 == 0)
                Console.WriteLine($"{number} is even number");
            else
                Console.WriteLine($"{number} is odd number");


            //|, &, ^, >>, <<
            if ((number & 1) == 0)
                Console.WriteLine($"{number} is even number");
            else
                Console.WriteLine($"{number} is odd number");


            Console.WriteLine((number & 1) == 0 ? $"{number} is even number" : $"{number} is odd number");

            Console.WriteLine($"{number} is {((number & 1) == 0 ? "even" : "odd")} number");
        }
    }
}

//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types

/* [static(Optional)] [Type] [Name]([Parameter1], [Parameter2],...)
 * [Name] = Verb + Noun
 * 
 * Example: 
 * void LearnBoolType()()
 * => [Type]                           = void
 * => [Name]                           = LearnBoolType
 * => ([Parameter1], [Parameter2],...) = ()
 */