using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search Recursive
            int[] numbers = new int[] { 2, 3, 7, 9, 10 };
            int result = BinarySearch.Search(numbers, 9, 0, numbers.Length - 1);
            Console.WriteLine("Recursive Result: {0}", result);

            result = BinarySearch.Search(numbers, 9);
            Console.WriteLine("Loop Result: {0}", result);
        }

    }
}
