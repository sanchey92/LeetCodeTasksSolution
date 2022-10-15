namespace LeetCodeTasks.Library;

public static class RemoveElementSolution
{
    public static int RemoveElement(int[] nums, int value)
    {
        var index1 = 0;
        var index2 = nums.Length;

        while (index1 < index2)
        {
            if (nums[index1] == value)
            {
                nums[index1] = nums[index2 - 1];
                index2--;
            }
            else
            {
                index1++;
            }
        }

        return index2;
    }
}