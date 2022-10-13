namespace LeetCodeTasks.Library;

public static class DuplicatesCleaner
{
    public static int RemoveDuplicatesFromSortedArray(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var i = 0;
        for (var j = 1; j < nums.Length; j++)
        {
            if (nums[j] == nums[i]) continue;
            i++;
            nums[i] = nums[j];
        }

        return i + 1;
    }
}