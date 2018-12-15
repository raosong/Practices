using System;

namespace Algorithms
{
    public class BinarySearch
    {
        int[] numbers;

        public BinarySearch(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            this.numbers = numbers;
        }

        public int Search(int target, bool recursive)
        {
            if (recursive)
            {
                return SearchRecursive(target, 0, this.numbers.Length - 1);
            }
            else
            {
                return SearchIterative(target);
            }
        }

        private int SearchRecursive(int target, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int mid = (start + end) / 2;
            if (this.numbers[mid] == target)
            {
                return mid;
            }
            else
            {
                if (this.numbers[mid] > target)
                {
                    return this.SearchRecursive(target, start, mid - 1);
                }
                else
                {
                    return this.SearchRecursive(target, mid + 1, end);
                }
            }
        }

        private int SearchIterative(int target)
        {
            int start = 0;
            int end = this.numbers.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (this.numbers[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    if (this.numbers[mid] < target)
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
