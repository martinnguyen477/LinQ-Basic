using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_005_OrderBy
{
    class Program
    {
        static void Student()
        {
            Console.OutputEncoding = Encoding.UTF8;
            IList<Student> ds = new List<Student>()
            {
                new Student() {StudentId = 1, StudentName = "Nguyễn Quốc Cường", StudentAge= 24},
                new Student() {StudentId = 2, StudentName = "Nguyễn Quốc Duy", StudentAge= 11},
                new Student() {StudentId = 3, StudentName = "Trần Hoài Đức", StudentAge= 16},
                new Student() {StudentId = 4, StudentName = "Trần Duy Nhất", StudentAge= 15},
                new Student() {StudentId = 5, StudentName = "Dương Thái Nhật", StudentAge= 12},
                new Student() {StudentId = 6, StudentName = "Nguyễn Phương Anh", StudentAge= 45},
            };


            var student = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 40);

            Console.WriteLine("Chưa sắp xếp");
            foreach (var i in student)
            {

                Console.WriteLine(i.StudentName);
            }


            Console.WriteLine("\n Đã sắp xếp cách 1: ");
            var studentOrder = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 40).OrderBy(s => s.StudentAge);

            Console.WriteLine("\n Đã sắp xếp cách 2: ");
            var studentOrder1 = student.OrderBy(s => s.StudentName);
            foreach (var i in studentOrder1)
            {
                Console.WriteLine(i.StudentName);
            }

           
            Console.WriteLine("\n Đã sắp xếp giảm dần");
            var student2 = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 40).OrderByDescending(s => s.StudentAge);
            foreach (var i in student2)
            {
                Console.WriteLine(i.StudentName);
            }

            Console.WriteLine("\n ThenBY");
                var student3 = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 40).OrderBy(s=> s.StudentAge).ThenBy(s => s.StudentAge);
            foreach (var i in student3)
            {
                Console.WriteLine(i.StudentName);
            }

            Console.WriteLine("\n Thenby Descending");
            var student4 = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 40).OrderBy(s => s.StudentAge).ThenByDescending(s => s.StudentAge);
            foreach (var i in student4)
            {
                Console.WriteLine(i.StudentName);
            }
            Console.WriteLine("\n  Reverse Ngược lại");
            var student5 = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 40).Reverse();
            foreach (var i in student5)
            {
                Console.WriteLine(i.StudentName);
            }
        }
        static void Main(string[] args)
        {
            Student();
        }
    }
}
