using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Join_Left_Right_Full
{
    class Program
    {
        public static void Join2()
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
                new Student { StudentId = 8, StudentName = "Nguyễn Thị Kim Anh", Age = 21},
                new Student { StudentId = 9, StudentName = "Võ Lê Ngọc Diệp", Age = 21},
            };

            IList<Standard> listStandard = new List<Standard>()
            {
                new Standard() { StandardId = 1, StandardName = "Đẹp Trai" },
                new Standard() { StandardId = 2, StandardName = "Xinh Gái" },
                new Standard() { StandardId = 3, StandardName = "OK" },
            };

            // Truy vấn cú pháp truy vấn.
            var innerLeftJoin = from s in listStudent
                             join st in listStandard on s.StandardId equals st.StandardId into cuong
                             from st2 in cuong.DefaultIfEmpty()
                             select new
                             {
                                 StudentName = s.StudentName,
                                 StandardName = st2?.StandardName
                             };

            var innerRightJoin = from st in listStandard
                                 join s in listStudent on st.StandardId equals s.StandardId into khanh
                                 from s2 in khanh.DefaultIfEmpty()
                             select new
                             {
                                 StudentName = s2?.StudentName,
                                 StandardName = st.StandardName
                             };

            Console.WriteLine("Xuất truy vấn cú pháp truy vấn LeftJoin");
            foreach (var obj in innerLeftJoin)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }

            Console.WriteLine("Xuất truy vấn cú pháp truy vấn RightJoin");
            foreach (var obj in innerRightJoin)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }
            Console.WriteLine(" \n Xuất truy vấn cú pháp truy vấn FullJoin");
            var fullJoin = innerLeftJoin.Union(innerRightJoin);
            foreach (var obj in fullJoin)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }


            var crossJoin = from s in listStudent
                            from c in listStandard
                            select new
                            {
                                StudentName = s.StudentName,
                                StandardName = c.StandardName
                            };
            Console.WriteLine(" \n Xuất truy vấn cú pháp truy vấn CrossJoin");
            foreach (var obj in crossJoin)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }

            Console.WriteLine(" \n Xuất truy vấn cú pháp truy vấn GroupJoin");
            var groupJoin = from st in listStandard
                                 join s in listStudent on st.StandardId equals s.StandardId into khanh
                                 select new
                                 {
                                     StandardId = st.StandardId,
                                     StandardName = st.StandardName,
                                     Student = khanh
                                 };

            foreach(var i in groupJoin)
            {
                Console.WriteLine("Department:" + i.StandardId + " - " + i.StandardName);
                if (i.Student != null)
                {
                    
                    Console.WriteLine("Employee Code\tEmployee Name");
                    foreach (var s in i.Student)
                    {
                        Console.WriteLine(s.StudentId + "\t\t" + s.StudentName);
                    }    
                }    
            }    
        }

        static void Main(string[] args)
        {
            Join2();
        }
    }
}
