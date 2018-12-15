using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch
    {
        public static int Search(int[] numbers, int target, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int mid = (start + end) / 2;
            if (numbers[mid] == target)
            {
                return mid;
            }
            else
            {
                if (numbers[mid] > target)
                {
                    return Search(numbers, target, start, mid - 1);
                }
                else
                {
                    return Search(numbers, target, mid + 1, end);
                }
            }
        }

        public static int Search(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (numbers[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    if (numbers[mid] < target)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
            }

            return -1;
        }
    }
}
