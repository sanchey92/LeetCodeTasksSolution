using System.Collections.Generic;

namespace LeetCodeTasks.Library
{
    public static class SingleNumber
    {
        public static int SearchSingeNumber(List<int> nums)
        {
            var mask = 0;
            
            foreach (var num in nums)
                mask ^= num;

            return mask;
        }
    }
}