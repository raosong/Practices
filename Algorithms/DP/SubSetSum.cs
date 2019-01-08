using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SubSetSum
    {
        public bool IsSubsetSumRecursive(int[] set, int sum)
        {
            return IsSubSetSumRecursiveInternal(set, set.Length - 1, sum);
        }

        public bool IsSubSetSumMemo(int[] set, int sum)
        {
            int[,] m = new int[set.Length + 1, sum + 1];
            for (int i = 0; i < set.Length + 1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {
                    m[i, j] = 2;
                }
            }

            return IsSubSetSumMemoInternal(set, set.Length - 1, sum, m);
        }

        private bool IsSubSetSumRecursiveInternal(int[] set, int n, int sum)
        {
            if (sum == 0)
            {
                return true;
            }

            if (n < 0)
            {
                return false;
            }

            var result = IsSubSetSumRecursiveInternal(set, n - 1, sum) || IsSubSetSumRecursiveInternal(set, n - 1, sum - set[n]);

            return result;
        }

        private bool IsSubSetSumMemoInternal(int[] set, int n, int sum, int[,] m)
        {
            if (m[n + 1, sum] < 2)
            {
                return m[n + 1, sum] == 1;
            }

            if (sum == 0)
            {
                m[n + 1, sum] = 1;
                return true;
            }

            if (n < 0)
            {
                m[n + 1, sum] = 0;
                return false;
            }

            bool result = false;
            if (set[n] > sum)
            {
                result = IsSubSetSumMemoInternal(set, n - 1, sum, m);
            }
            else
            {
                result = IsSubSetSumMemoInternal(set, n - 1, sum, m) || IsSubSetSumMemoInternal(set, n - 1, sum - set[n], m);
            }

            return result;
        }

        public bool IsSubSetSumDP(int[] set, int sum)
        {
            bool?[,] m = new bool?[set.Length + 1, sum + 1];

            PrepareTable(set, sum, m);

            return m[set.Length, sum].Value;
        }

        public List<List<int>> PrintSets(int[] set, int sum)
        {
            bool?[,] m = new bool?[set.Length + 1, sum + 1];

            PrepareTable(set, sum, m);
            List<int> subset = null;
            List<List<int>> allSubsets = null;

            PrintSetsInternal(set, set.Length, sum, m, ref subset, ref allSubsets);

            return allSubsets;
        }

        private void PrintSetsInternal(int[] set, int n, int sum, bool?[,] m, ref List<int> subset, ref List<List<int>> allSubsets)
        {
            if (sum == 0)
            {
                subset = new List<int>();
                if (allSubsets == null)
                {
                    allSubsets = new List<List<int>>();
                }

                allSubsets.Add(subset);
            }

            if (n >= 1 && m[n, sum].Value == true)
            {
                if (m[n - 1, sum].Value && sum > 0)
                {
                    PrintSetsInternal(set, n - 1, sum, m, ref subset, ref allSubsets);
                }

                if (sum >= set[n - 1])
                {
                    if (m[n, sum - set[n - 1]].Value == true)
                    {
                        PrintSetsInternal(set, n - 1, sum - set[n - 1], m, ref subset, ref allSubsets);
                        subset.Add(set[n - 1]);
                    }
                }
            }
        }


        private void PrepareTable(int[] set, int sum, bool?[,] m)
        {

            for (int i = 0; i <= set.Length; i++)
            {
                m[i, 0] = true;
            }

            for (int j = 1; j <= sum; j++)
            {
                m[0, j] = false;
            }

            for (int i = 1; i <= set.Length; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (set[i - 1] > j)
                    {
                        m[i, j] = m[i - 1, j].Value;
                    }
                    else
                    {
                        m[i, j] = m[i - 1, j].Value || m[i - 1, j - set[i - 1]].Value;
                    }
                }
            }
        }



        //////////////////////////////////////set[]={1,2,3,4,5,6}  sum=6////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// {1,2,3} {2,4}, {1,5}, {6}/////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        //                                                                                                                  ------------------m[6,6]-------------------
        //                                                                                                                 /                                           \
        //                                                                                                                /                                             \
        //                                                                -------------------------------------------- m[5,6]-------------------------------           m[5,0]
        //                                                               /                                                                                  \
        //                                                              /                                                                                    \
        //                                   ------------------------ m[4,6]-----------------------                                                  ------m[4,1]---------
        //                                 /                                                        \                                               /                     \
        //                                /                                                          \                                             /                       \
        //                   ------- m[3,6]---------                                           -----m[3,2]----                             -----m[3,1]------             m[3,-3]                                    
        //                  /                        \                                        /               \                           /                 \                      
        //                 /                          \                                      /                 \                         /                   \                      
        //                /                            \                                    /                   \                       /                     \                      
        //               /                              \                                  /                     \                     /                       \                      
        //            m[2,6]                           m[2,3]                           m[2,2]                  m[2,-1]            m[2,1]                   m[2,-2]                      
        //         /          \                     /          \                     /          \                               /          \                      
        //        /            \                   /            \                   /            \                             /            \                      
        //       /              \                 /              \                 /              \                           /              \                      
        //    m[1,6]          m[1,4]          m[1,3]           m[1,1]           m[1,2]          m[1,0]                    m[1,1]           m[1,-1]                      
        //   /      \        /      \        /      \        /       \         /      \                                  /      \                            
        // m[0,6]  m[0,5]  m[0,4]  m[0,3]  m[0,3]  m[0,2]  m[0,1]  m[0,0]    m[0,2]  m[0,1]                             m[0,1]  m[0,0]                       



    }
}
