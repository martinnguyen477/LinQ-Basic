using System;
using System.Linq;
using System.Text;

namespace LINQ_Count
{
    public class Program
    {
        public static void Count()
        {
            int[] s = { 1, 12, 24, 52, 12, 78 };
            int count = s.Count();
            Console.WriteLine("Số phần từ là : {0}", count);
        }
        public static void LongCount()
        {
            int[] s = { 1, 4, 6, 3, 6, 2, 6, 2, 7 };
            long count = s.LongCount();
            Console.WriteLine("Số phần từ long count là : {0}", count);
        }
        public static void Max()
        {
            int[] s = { 1, 5, 6, 12, 124, 6, 12, 512, 6212 };
            int max = s.Max();
            int max2 = s.Max(s => s % 2 == 0 ? s : 0);
            Console.WriteLine("Giá trị lớn nhất là : {0}", max);
            Console.WriteLine("Giá trị lớn nhất và chia hết cho 2 là : {0}", max2);
        }
        public static void Min()
        {
            int[] s = { 1, 5, 2, 65, 1, 6, 12, 6, 12, 6, 123, 6, 12, 6 };
            int min = s.Min();
            Console.WriteLine("Giá trị nhỏ nhất là: {0}", min);
        }
        public static void Sum()
        {
            int[] s = { 4, 6, 123, 6, 12, 6, 12 };
            int sum = s.Sum(s => s % 2 == 0 ? s : 0);
            Console.WriteLine("Tổng các số mà chia hết cho 2 là : {0} ", sum);
        }
       static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Min();
            Sum();
            Max();
            LongCount();
            Count();
        }
    }
}
