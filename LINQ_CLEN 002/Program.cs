using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_CLEN_002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Hàm để viết tiếng Việt.
            Console.OutputEncoding = Encoding.UTF8;

            // Cho một cái mảng của đối tượng.
            Student[] studentArray =
            {
                new Student() { StudentID = 5, StudentName = "Cường", Age = 6 },
                new Student() { StudentID = 1, StudentName = "Duy", Age = 14 },
                new Student() { StudentID = 2, StudentName = "Duy Cường", Age = 33 },
                new Student() { StudentID = 3, StudentName = "Hoài Đức", Age = 3 },
            };

            // Nếu là mảng kiểu string, int,... thì để biến được còn mảng đối tượng thì phải khai báo và add vô.
            var students = new List<Student>();

            foreach (Student student in studentArray)
            {
                if (student.Age > 12 && student.Age < 20)
                {
                    students.Add(student);
                }
            }

            foreach (var s in students)
            {
                Console.WriteLine(s.StudentName);
                Console.WriteLine(s.StudentID);
            }

            var students1 = studentArray.Where(s => s.Age < 13 || s.Age > 20);

            foreach (var student in students1)
            {
                Console.WriteLine("Sinh Viên Tên {0}", student.StudentName);
            }

            var students22 = studentArray.Where(s => s.StudentName == "Cường").FirstOrDefault();

            Console.WriteLine("Có sinh viên là {0}", students22.StudentName);
        }
    }
}
