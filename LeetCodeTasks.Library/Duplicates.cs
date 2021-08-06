using System.Collections.Generic;

namespace LeetCodeTasks.Library
{
    public static class Duplicates
    {
        public static bool HasDuplicates(IEnumerable<int> nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (hashSet.Contains(num))
                    return true;
                else
                    hashSet.Add(num);
            }

            return false;
        }
    }
}