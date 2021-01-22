using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Element_First_Last_Single
{
    class Program
    {
        static void ElementAt()
        {
            int[] s = { 3, 5, 1, 6, 1, 6, 12, 5, 12, 6, 12 };
            var result1 = s.ElementAt(4);
            Console.WriteLine("Phần tử thứ 5 là : {0}", result1);
            IList<string> x = new List<string>()
            {
                "Cng",
                "Duy",
                "Huy",
                "Tng",
                "Khnh"
            };
            var result2 = x.ElementAt(3);
            Console.WriteLine("Phần tử thứ 6 là : {0}", result2);

        }
        static void Main(string[] args)
        {
            ElementAt();
        }
    }
}
