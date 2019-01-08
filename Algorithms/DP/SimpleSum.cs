using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SimpleSum
    {
        int count = 0;
        public int SimpleSumPlus(string s, int sum)
        {
            count = 0;
            int[,,] m = new int[s.Length, s.Length, sum + 1];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    for (int k = 0; k < sum + 1; k++)
                    {
                        m[i, j, k] = int.MaxValue;
                    }
                }
            }

            int minPlusCount = GetMinPlus(s, 0, s.Length - 1, sum, m);
            if (minPlusCount >= int.MaxValue - 1)
            {
                minPlusCount = -1;
            }

            System.Diagnostics.Debug.WriteLine("Recursive Count: {0}", count);

            return minPlusCount;
        }

        private int GetMinPlus(string s, int i, int j, int sum, int[,,] m)
        {
            if (m[i, j, sum] < int.MaxValue)
            {
                return m[i, j, sum];
            }

            count++;
            System.Diagnostics.Debug.WriteLine("{0} - {1}, {2}, {3}", i, j, sum, m[i, j, sum]);

            string currentS = s.Substring(i, j - i + 1);

            if (currentS.Length < 10)
            {
                int directValue = int.Parse(currentS);
                if (directValue == sum)
                {
                    m[i, j, sum] = 0;
                    return m[i, j, sum];
                }
            }

            if (i == j)
            {
                m[i, j, sum] = int.MaxValue - 1;
            }
            else
            {
                int minPlusCount = int.MaxValue;
                for (int iSum = 0; iSum <= sum; iSum++)
                {
                    for (int k = i; k < j; k++)
                    {
                        int sum1 = GetMinPlus(s, i, k, iSum, m);
                        int sum2 = GetMinPlus(s, k + 1, j, sum - iSum, m);

                        int plusCount = int.MaxValue;
                        if (sum1 < int.MaxValue - 1 && sum2 < int.MaxValue - 1)
                        {
                            plusCount = sum1 + sum2 + 1;
                        }

                        if (plusCount < minPlusCount)
                        {
                            minPlusCount = plusCount;
                        }
                    }
                }

                m[i, j, sum] = minPlusCount == int.MaxValue ? int.MaxValue - 1 : minPlusCount;
            }

            return m[i, j, sum];

        }
    }
}
