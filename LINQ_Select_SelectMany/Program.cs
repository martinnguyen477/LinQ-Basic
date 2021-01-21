// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using LINQ_GroupJoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Select_SelectMany
{
    public class Program
    {
        public static void Select()
        {
            IList<Student> listStudent = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "Nguyễn Quốc Cường", Age = 21, StandardId = 1 },
                new Student() { StudentId = 2, StudentName = "Nguyễn Quốc Khánh", Age = 16, StandardId = 1 },
                new Student() { StudentId = 3, StudentName = "Nguyễn Văn Hùng", Age = 49, StandardId = 2 },
                new Student() { StudentId = 4, StudentName = "Nguyễn Thị Thúy Nga", Age = 24, StandardId = 3 },
                new Student() { StudentId = 5, StudentName = "Nguyễn Thị Ánh Tuyết", Age = 48, StandardId = 2 },
                new Student() { StudentId = 6, StudentName = "Trần Hoài Đức", Age = 21, StandardId = 1 },
                new Student() { StudentId = 7, StudentName = "Dương Thái Nhật", Age = 21, StandardId = 3 },
                new Student() { StudentId = 8, StudentName = "Nguyễn Thị Kim Anh", Age = 21, StandardId = 2 },
                new Student() { StudentId = 9, StudentName = "Võ Lê Ngọc Diệp", Age = 21, StandardId = 3 },
            };
            var resultSelect = from s in listStudent
                               select s.StudentName;
            foreach (var s in resultSelect)
            {
                Console.WriteLine(s);
            }

            var resultSelectMany = from s in listStudent
                                   select new
                                   {
                                       Name = "Mr." + s.StudentName,
                                       Age = s.Age,
                                   };
            var resultSelectMany2 = listStudent.Select(s => new
            {
                Name = "Mr. " + s.StudentName,
                Age = s.Age,
            });
            foreach (var item in resultSelectMany)
            {
                Console.WriteLine("Student Name : {0}, Age: {1}", item.Name, item.Age);
            }

            Console.WriteLine("Cú pháp  phương thức: ");
            foreach (var item in resultSelectMany2)
            {
                Console.WriteLine("Student Name : {0}, Age: {1}", item.Name, item.Age);
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Select();
        }
    }
}
