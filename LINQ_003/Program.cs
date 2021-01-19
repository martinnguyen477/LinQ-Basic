using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_003
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IList<string> stringList = new List<string>()
            {
                "C# Tutorial",
                "VB.NET Tutorial",
                "Learn C++",
                "MVC Tutorial",
                "Java"
            };

            var result = from s in stringList
                         where s.Contains("Tutorial")
                         select s;

            var result1 = stringList.Where(s => s.Contains("Tutorial")).ToList();
            foreach (var s in result)
            {
                Console.WriteLine("Chuỗi {0}", s);
            }

            foreach( var s in result1)
            {
                Console.WriteLine("Chuỗi {0}", s);
            }    

        }
    }
}
