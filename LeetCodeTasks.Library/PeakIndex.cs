namespace LeetCodeTasks.Library
{
    public static class PeakIndex
    {
        public static int FindPeakIndex(int[] array)
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                if (array[middle] < array[middle + 1])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return left;
        }
    }
}