using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Factorial
    {
        public int Fact(int n)
        {
            Debug.WriteLine("Fact({0})", n);
            if (n < 0)
            {
                throw new ArgumentException("n must be a non-negative integer.");
            }

            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }
        }
    }
}
