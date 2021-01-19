using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_004_Where
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

            var student = from s in ds
                          where s.StudentAge > 12 && s.StudentAge < 20
                          select s;
            var student2 = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 20);
           
            Console.WriteLine("Cách 1:");
            foreach( var i in student)
            {
                
                Console.WriteLine(i.StudentName);
            }    
            
        }
        static void Student2()
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

            
            var student2 = ds.Where(s => s.StudentAge > 12 && s.StudentAge < 20);
            
            Console.WriteLine("\n Cách 2:");
            foreach (var i in student2)
            {
                
                Console.WriteLine(i.StudentName);
            }

        }


        static void Student3()
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
            Func<Student, bool> isSt = delegate (Student s)
             {
                 return s.StudentAge > 12 && s.StudentAge < 20;
             };
            
            var student2 = from s in ds
                           where isSt(s)
                           select s.StudentName;

            Console.WriteLine("\n Cách số 3 ");
            foreach (var i in student2)
            {
                //Console.WriteLine("Sinh viên thứ {0}", k++);
                Console.WriteLine(i);
            }
        }
        static void Student4()
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
            static bool isSt(Student student)
            {
                return student.StudentAge > 12 && student.StudentAge < 20;
            }
            
            var student2 = from s in ds
                           where isSt(s)
                           select s.StudentName;
            Console.WriteLine("\n Cách 4");
            foreach (var i in student2)
            {
                //Console.WriteLine("Sinh viên thứ {0}", k++);
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Student();
            Student2();
            Student3();
            Student4();

        }
    }
}
