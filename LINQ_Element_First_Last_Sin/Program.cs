using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Element_First_Last_Sin
{
    class Program
    {
        static void Element()
        {
            int[] s = { 4, 5, 1, 6, 1, 6, 1, 6, 13 };
            IList<string> x = new List<string>()
            {
                "Cuong",
                "Khanh",
                "Nga",
                "Huy",
                "Duy",
                "Duc"
            };


            var result = s.ElementAt(4);
            Console.WriteLine(result);
            var result2 = x.ElementAt(3);
            Console.WriteLine(result2);
        }
        static void ElementAtOrDefault()
        {
            int[] s = { 4, 5, 1, 6, 1, 6, 1, 6, 13 };
            IList<string> x = new List<string>()
            {
                "Cuong",
                "Khanh",
                "Nga",
                "Huy",
                "Duy",
                "Duc"
            };
            var result = s.ElementAtOrDefault(4);
            Console.WriteLine(result);
            var result2 = x.ElementAtOrDefault(8);
            Console.WriteLine(result2);
        }
        static void First()
        {
            int[] s = { 4, 5, 1, 6, 1, 6, 1, 6, 13 };
            IList<string> x = new List<string>()
            {
                "Cuong",
                "Khanh",
                "Nga",
                "Huy",
                "Duy",
                "Duc"
            };
            var result = s.First( s => s % 2 == 0               );
            Console.WriteLine(result);
            var result2 = x.FirstOrDefault();
            Console.WriteLine(result2);
        }
        static void Last()
        {
            int[] s = { 4, 5, 1, 6, 1, 6, 1, 6, 13 };
            IList<string> x = new List<string>()
            {
                "Cuong",
                "Khanh",
                "Nga",
                "Huy",
                "Duy",
                "Duc"
            };
            var result = s.Last(s => s % 2 == 0);
            Console.WriteLine(result);
            var result2 = x.LastOrDefault();
            Console.WriteLine(result2);
        }
        static void Main(string[] args)
        {
            Element();
            ElementAtOrDefault();
            First();
            Last();
        }
    }
}
