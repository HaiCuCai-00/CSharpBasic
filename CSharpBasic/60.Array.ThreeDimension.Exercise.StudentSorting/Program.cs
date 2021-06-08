using System;

namespace _60.Array.ThreeDimension.Exercise.StudentSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[1, 2, 2] //[Planes, Rows, Columns] => [Classes, Units, Members]
            {
                //Class 12A
                {
                    //Unit 1
                    {
                        new Student{ Id = 10, Name = "Manh" },
                        new Student{ Id = 2, Name = "Nhi" }
                    },
                    //Unit 2
                    {
                        new Student{ Id = 4, Name = "Tran"},
                        new Student{ Id = 5, Name = "Ha" }
                    }
                }
                //Class 12B
                //{}
            };

            //SortStudentById(students);
            SortStudentByName(students);
            DisplayStudent(students);
        }

        private static (int plane, int row, int column) ConvertFrom1DTo3D(Student[,,] array, int t)
        {
            //i = t / (Rows * Columns)
            int i = t / (array.GetLength(1) * array.GetLength(2));

            //b = t % (Rows * Columns)
            int b = t % (array.GetLength(1) * array.GetLength(2));

            //j = b / Columns
            int j = b / array.GetLength(2);

            //v = b % Columns
            int v = b % array.GetLength(2);

            return (i, j, v);
        }

        private static void SortStudentById(Student[,,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var current = ConvertFrom1DTo3D(array, i);
                var min = current;

                for (int j = i + 1; j < array.Length; j++)
                {
                    var temp = ConvertFrom1DTo3D(array, j);
                    //Sorting Logic
                    if (array[temp.plane, temp.row, temp.column].Id < array[min.plane, min.row, min.column].Id)
                        min = temp;
                }


                (array[current.plane, current.row, current.column], array[min.plane, min.row, min.column])
                    = (array[min.plane, min.row, min.column], array[current.plane, current.row, current.column]);
            }
        }

        private static void SortStudentByName(Student[,,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var current = ConvertFrom1DTo3D(array, i);
                var min = current;

                for (int j = i + 1; j < array.Length; j++)
                {
                    var temp = ConvertFrom1DTo3D(array, j);
                    //Sorting Logic
                    /* string a, string b => a.CompareTo(b) =>
                     * < 0: a < b or
                     * = 0: a = b or
                     * > 0: a > b
                     */
                    if (array[temp.plane, temp.row, temp.column].Name
                        .CompareTo(array[min.plane, min.row, min.column].Name) < 0)                      
                        min = temp;
                }


                (array[current.plane, current.row, current.column], array[min.plane, min.row, min.column])
                    = (array[min.plane, min.row, min.column], array[current.plane, current.row, current.column]);
            }
        }

        private static void DisplayStudent(Student[,,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var p = ConvertFrom1DTo3D(array, i);

                if (p.row == 0 && p.column == 0)
                    Console.WriteLine($"Class: {p.plane}");

                if (p.column == 0)
                    Console.Write($"\tUnit {p.row}: ");

                var student = array[p.plane, p.row, p.column];
                Console.Write($"{student.Id,2}-{student.Name,-4} ");

                if (p.column == (array.GetLength(2) - 1))
                    Console.WriteLine();
            }
        }
    }
    class Student
    {
        //field
        private int id;

        //properyies
        public int Id { get => id; set => id = value; }
        public string Name { get; set; }
    }
}
