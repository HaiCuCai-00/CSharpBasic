using System;

namespace _08.Array.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3]; 
            //[ , , ]
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;
            //[1, 2, 3]

            for (int i = 0; i < arr1.Length; i++)
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            Console.WriteLine();

            //[1, 2, 3]
            arr1[1] = 4;
            for (int i = 0; i < arr1.Length; i++)
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            Console.WriteLine();

            string[] arr2 = new string[] { "Nguyen", "Hung", "Manh", "Dep", "Trai" };
            //arr2.Length => 5
            //Index       => 0, 1, 2, 3, 4

            foreach (var x in arr2)
                Console.WriteLine(x);
            Console.WriteLine();

            Student[] students = new Student[3];
            //[ , , ]
            Student s1 = new Student();
            s1.Name = "Manh";

            students[0] = s1;
            //[Student(Name = Manh), , ]

            students[1] = new Student();
            students[1].Name = "Ha";
            //[Student(Name = Manh), Student(Name = Ha), ]

            students[2] = new Student();
            students[2].Name = "Nga";
            //[Student(Name = Manh), Student(Name = Ha), Student(Name = Nga)]

            foreach (var x in students)
                Console.WriteLine(x.Name);
       
        }

        struct Student
        {
            public string Name;
        }
    }
}
