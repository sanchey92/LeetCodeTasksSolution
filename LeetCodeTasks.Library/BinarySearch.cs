namespace LeetCodeTasks.Library
{
    public static class BinarySearch
    {
        public static int SearchIndex(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (numbers[middle] == target)
                {
                    return middle;
                }

                if (numbers[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}