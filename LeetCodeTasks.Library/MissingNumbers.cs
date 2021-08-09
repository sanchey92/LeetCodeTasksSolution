using System.Linq;

namespace LeetCodeTasks.Library
{
    public static class MissingNumbers
    {
        public static int Search(int[] nums)
        {
            return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
        }
    }
}