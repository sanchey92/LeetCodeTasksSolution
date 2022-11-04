using System;

namespace LeetCodeTasks.Library;

public static class ThirdMaxSolution
{
    public static int FindThirdMax(int[] nums)
    {
        Array.Sort(nums);

        for (var i = 0; i < nums.Length / 2; i++)
            (nums[i], nums[nums.Length - 1 - i]) = (nums[nums.Length  - 1 - i], nums[i]);

        var elemCounted = 1;
        var prevElem = nums[0];
        
        foreach (var num in nums)
        {
            if (num != prevElem)
            {
                elemCounted += 1;
                prevElem = num;
            }

            if (elemCounted == 3)
                return num;
        }

        return nums[0];
    }
}