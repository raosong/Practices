using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Fib
    {
        private int[] fibs;

        public int[] GenerateFibs(int number, bool recursive)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("number should be a positive number.");
            }

            this.fibs = new int[number + 1];

            if (recursive == true)
            {
                GenerateRecursive(number);
            }
            else
            {
                GenerateIterative();
            }

            return this.fibs;
        }

        private void GenerateRecursive(int n)
        {
            Debug.WriteLine("Generate({0})", n);

            if (n == 1 || n == 2)
            {
                this.fibs[n] = 1;
            }
            else
            {
                if (this.fibs[n - 1] == 0)
                {
                    GenerateRecursive(n - 1);
                }

                if (this.fibs[n - 2] == 0)
                {
                    GenerateRecursive(n - 2);
                }

                this.fibs[n] = this.fibs[n - 1] + this.fibs[n - 2];
            }
        }

        private void GenerateIterative()
        {
            for (int i = 1; i < this.fibs.Length; i++)
            {
                if (i == 1 || i == 2)
                {
                    this.fibs[i] = 1;
                }
                else
                {
                    this.fibs[i] = this.fibs[i - 1] + this.fibs[i - 2];
                }
            }
        }
    }
}
