using System;
using System.Linq;

namespace LINQ_Any_All_Contains
{
    class Program
    {                                                                                                                                                                                                                                                                                                                                                                           
        static void All()
        {
            int[] s = { 1, 3, 6, 2, 6, 2, 12, 8, 6, 3, 8, 34 };
            bool result = s.All(s => s % 2 == 0 );
            Console.WriteLine(result);
            bool result2 = s.Any(s => s % 2 == 0);
            Console.WriteLine(result2);
            bool result3 = s.Contains(1);
            Console.WriteLine(result3);
        }

        static void Main(string[] args)
        {
            All();
        }
    }
}
