using System;
using System.Collections.Generic;

namespace LeetCodeTasks.Library
{
    public static class MaximumSubarray
    {
        public static int FindMaxSum(List<int> nums)
        {
            var maxSum = nums[0];
            var currentSum = nums[0];

            for (var i = 1; i < nums.Count; i++)
            {
                var num = nums[i];
                currentSum = Math.Max(currentSum + num, num);
                maxSum = Math.Max(currentSum, maxSum);
            }
            
            return maxSum;
        }
    }
}