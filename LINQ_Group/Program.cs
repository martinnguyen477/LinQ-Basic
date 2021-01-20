// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Group
{
    public class Program
    {
        public static void Student()
        {
            Console.OutputEncoding = Encoding.UTF8;
            IList<Student> listStudent = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "Nguyễn Quốc Cường", Age = 21 },
                new Student() { StudentId = 2, StudentName = "Nguyễn Quốc Khánh", Age = 16 },
                new Student() { StudentId = 3, StudentName = "Nguyễn Văn Hùng", Age = 49 },
                new Student { StudentId = 4, StudentName = "Nguyễn Thị Thúy Nga", Age = 24 },
                new Student { StudentId = 5, StudentName = "Nguyễn Thị Ánh Tuyết", Age = 48 },
                new Student { StudentId = 6, StudentName = "Trần Hoài Đức", Age = 21 },
                new Student { StudentId = 7, StudentName = "Dương Thái Nhật", Age = 21 },
                new Student { StudentId = 8, StudentName = "Nguyễn Thị Kim Anh", Age = 21 },
                new Student { StudentId = 9, StudentName = "Võ Lê Ngọc Diệp", Age = 21 },
            };

            var groupStudent = from s in listStudent
                               group s by s.Age;

            Console.WriteLine("Truy vấn theo cú pháp truy vấn : ");
            foreach (var ageGroup in groupStudent)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);
                foreach (Student s in ageGroup)
                {
                    Console.WriteLine("Student Name {0}", s.StudentName);
                }
            }

            var groupStudent2 = listStudent.GroupBy(s => s.Age);
            Console.WriteLine("Truy vấn theo cú pháp phương thức : ");
            foreach (var ageGroup in groupStudent2)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);
                foreach (Student s in ageGroup)
                {
                    Console.WriteLine("Student Name {0}", s.StudentName);
                }
            }
        }

        public static void Main(string[] args)
        {
            Student();
        }
    }
}
