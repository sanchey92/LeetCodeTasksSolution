namespace LeetCodeTasks.Library;

public static class SortArraySolution
{
    public static int[] SortArrayByParity(int[] nums)
    {
        var oddPointer = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0) continue;
            
            (nums[oddPointer], nums[i]) = (nums[i], nums[oddPointer]);
            oddPointer++;
        }
        return nums;
    }
}