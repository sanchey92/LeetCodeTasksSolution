using System.Collections;
using System.Collections.Generic;

namespace LeetCodeTasks.Library
{
    public static class SubarraySumEqualsK
    {
        // cumulative sum without space
        public static int GetCumulativeSumCount(int[] array, int k)
        {
            var count = 0;
            var length = array.Length;
            for (var start = 0; start < length; start++)
            {
                var sum = 0;
                for (var end = start; end < length; end++)
                {
                    sum += array[end];
                    if (sum == k)
                        count++;
                }
            }

            return count;
        }
    }
}