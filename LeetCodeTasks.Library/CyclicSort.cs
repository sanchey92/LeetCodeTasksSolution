using System.Collections.Generic;

namespace LeetCodeTasks.Library
{
    public static class CyclicSort
    {
        public static List<int> FindDisappearedNumbers(List<int> nums)
        {
            var disappearedNumbers = new List<int>();

            var i = 0;
            while (i < nums.Count)
            {
                var position = nums[i] - 1;
                if (nums[i] != nums[position])
                    (nums[i], nums[position]) = (nums[position], nums[i]);
                else
                    i += 1;
            }

            for (var j = 0; j < nums.Count; j++)
            {
                if (nums[j] != j + 1)
                    disappearedNumbers.Add(j + 1);
            }

            return disappearedNumbers;
        }
    }
}