using System;

namespace _31.Algorithm.SelectionSorting
{
    class FinPinNuberProgram
    {
        static void Main1(string[] args)
        {
            int[] numbers = new[] { -9, 0, 78, 10, -13, -2, 20, 19, 36 };

            int min = numbers.Length > 0 ? numbers[0] : throw new Exception("Array is empty");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Min = {min}");
        }
    }
    class SelectionSortProgam
    {
        static void Main1(string[] args)
        {
            int[] numbers = new[] { -8, 10, 9, 5, 6, 1, -10, -2, 13 };
            int min, temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                min = i;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min])
                        min = j;
                }

                temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }
            Console.WriteLine(string.Join(",", numbers));
        }
    }
    class StudentSortProgram
    {
        static void Main(string[] args)
        {
            Student hai = new Student()
            {
                Id = 1,
                Mark = 10.0f,
                Name = "Hai"   
            };
            Console.WriteLine($"{hai.Id} - {hai.Name} - {hai.Mark}");
            Console.WriteLine();

            Student[] students = new Student[]
        {
            hai,
            new Student{Id = 2, Name = "Ngoc", Mark = 9f},
                new Student{Id = 3, Name = "Nam", Mark = 2f},
                new Student{Id = 4, Name = "Nhu", Mark = 5f},
                new Student{Id = 5, Name = "Nhung", Mark = 9f},
                new Student{Id = 6, Name = "Thu", Mark = 8f},
                new Student{Id = 7, Name = "Nga", Mark = 5f},
                new Student{Id = 8, Name = "Nguyen", Mark = 1f},
                new Student{Id = 9, Name = "Nguyet", Mark = 7f},
                new Student{Id = 10, Name = "Nha", Mark = 7f},
                new Student{Id = 11, Name = "Bich", Mark = 7f},
                new Student{Id = 12, Name = "Anh", Mark = 7f},
                new Student{Id = 13, Name = "Dung", Mark = 7f},
                new Student{Id = 14, Name = "Thuy", Mark = 7f},
                new Student{Id = 15, Name = "Thao", Mark = 7f}
        };

            int min;
            Student temp;

            for (int i = 0; i< students.Length  ; i++)
            {
                min = i;
                for (int j = i +1 ; j < students.Length; j++)
                {
                    if (students[j].Mark < students[min].Mark)
                        min = j;
                }
                /*
                 * temp = students[i];
                   students[i] = students[min];
                   students[min] = temp;
                */
                (students[i], students[min]) = (students[min], students[i]);
            }
            foreach (var item in students)
                Console.WriteLine($"ID: {item.Id,2} - Name: {item.Name, -6} - Mark: {item.Mark}");


        }

        struct Student
        {
            public int Id { get; set; } // prob tab*2
            public string Name { get; set; }
            public float Mark { get; set; }

        }
    }
}
