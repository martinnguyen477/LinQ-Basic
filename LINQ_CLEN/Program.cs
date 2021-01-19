// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LINQ_CLEN
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Mảng tên .
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // Câu truy vấn ra name.
            // from name in names có nghĩa là từ mỗi phần tử trong danh sách.
            var myLinqQuery = from name in names
                              where name.Contains("a")
                              select name;

            var myLinq = names.Where(s => s.Contains("a"));

            // Dùng foreach xuất ra .
            // var là tạo biến ngầm định tự hiểu kiểu dữ liệu.
            // var in myLinqQuery có nghĩa là mỗi phần tử trong danh sách myLinqQuery.
            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Sử dụng Lambda");

            foreach (var i in myLinq)
            {
                Console.WriteLine(i);
            }
        }
    }
}
