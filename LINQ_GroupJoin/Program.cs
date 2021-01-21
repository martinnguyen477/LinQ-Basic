using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_GroupJoin
{
    public class Program
    {
        public static void GroupJoin()
        {
            IList<Student> listStudent = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "Nguyễn Quốc Cường", Age = 21, StandardId = 1 },
                new Student() { StudentId = 2, StudentName = "Nguyễn Quốc Khánh", Age = 16, StandardId = 1 },
                new Student() { StudentId = 3, StudentName = "Nguyễn Văn Hùng", Age = 49, StandardId = 2 },
                new Student { StudentId = 4, StudentName = "Nguyễn Thị Thúy Nga", Age = 24, StandardId = 3 },
                new Student { StudentId = 5, StudentName = "Nguyễn Thị Ánh Tuyết", Age = 48, StandardId = 2 },
                new Student { StudentId = 6, StudentName = "Trần Hoài Đức", Age = 21, StandardId = 1 },
                new Student { StudentId = 7, StudentName = "Dương Thái Nhật", Age = 21, StandardId = 3 },
                new Student { StudentId = 8, StudentName = "Nguyễn Thị Kim Anh", Age = 21, StandardId = 2 },
                new Student { StudentId = 9, StudentName = "Võ Lê Ngọc Diệp", Age = 21, StandardId = 3 },
            };

            IList<Standard> listStandard = new List<Standard>()
            {
                new Standard() { StandardId = 1, StandardName = "Đẹp Trai" },
                new Standard() { StandardId = 2, StandardName = "Xinh Gái" },
                new Standard() { StandardId = 3, StandardName = "OK" },
            };

            var groupJoin = listStandard.GroupJoin(
                listStudent,
                s => s.StandardId,
                st => st.StandardId,
                (s, studentGroup) => new
                {
                    Students = studentGroup,
                    StandardFullName = s.StandardName,
                });
            foreach (var s in groupJoin)
            {
                Console.WriteLine("{0}: ", s.StandardFullName);
                foreach (var item in s.Students)
                {
                    Console.WriteLine("- {0}", item.StudentName);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GroupJoin();
        }
    }
}
