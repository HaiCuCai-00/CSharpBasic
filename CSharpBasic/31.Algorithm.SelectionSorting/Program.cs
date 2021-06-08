using System;

namespace _31.Algorithm.SelectionSorting
{
    class FindMinNumberProgram
    {
        static void Main1(string[] args)
        {
            int[] numbers = new[] { -9, 0, 78, 10, -12, -2, 20, 19, 36 };

            int min = numbers.Length > 0
                ? numbers[0]
                : throw new Exception("Array is empty");

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] < min) min = numbers[i];

            Console.WriteLine($"Min = {min}");
        }
    }

    class SelectionSortProgam
    {
        static void Main1(string[] args)
        {
            int[] numbers = new[] { -8, 10, 9, 5, 6, 1, -10, -2, 13 };
            int min;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] < numbers[min]) min = j;

                (numbers[i], numbers[min]) = (numbers[min], numbers[i]);
            }

            Console.WriteLine(string.Join(",", numbers));
        }
    }

    class StudentSortProgram
    {
        static void Main(string[] args)
        {
            //object
            Student manh = new Student() { Id = 1, Name = "Manh", Mark = 10.0f };

            Console.WriteLine($"Id: {manh.Id} - Name: {manh.Name} - Mark: {manh.Mark}");
            Console.WriteLine();

            Student[] students = new Student[]
            {
                manh,
                new Student{Id = 2, Name = "Ngoc", Mark = 9f},
                new Student{Id = 3, Name = "Thanh", Mark = 8.5f},
                new Student{Id = 4, Name = "Trang", Mark = 8f},
                new Student{Id = 5, Name = "Luat", Mark = 1f},
                new Student{Id = 6, Name = "Giang", Mark = 2f},
                new Student{Id = 7, Name = "Huy", Mark = 5f},
                new Student{Id = 8, Name = "Hari Won", Mark = 4.5f},
                new Student{Id = 9, Name = "Trinh", Mark = 6f},
                new Student{Id = 10, Name = "Tiep", Mark = 10f},
                new Student{Id = 11, Name = "Ha", Mark = 7f},
                new Student{Id = 12, Name = "Quach", Mark = 7.5f},
                new Student{Id = 13, Name = "Ngao", Mark = 3f},
                new Student{Id = 14, Name = "Cao", Mark = 3.5f},
                new Student{Id = 15, Name = "Bone", Mark = 4f}
            };

            int min;

            for (int i = 0; i < students.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < students.Length; j++)
                    //if (students[j].Mark < students[min].Mark) min = j;
                    if (students[j].Name.CompareTo(students[min].Name) < 0) min = j;

                (students[i], students[min]) = (students[min], students[i]);
            }

            foreach (var item in students)
                Console.WriteLine($"Id: {item.Id,2} - Name: {item.Name,-8} - Mark: {item.Mark}");

        }

        struct Student
        {
            //Properties
            public int Id { get; set; }
            public string Name { get; set; }
            public float Mark { get; set; }
        }
    }
}
