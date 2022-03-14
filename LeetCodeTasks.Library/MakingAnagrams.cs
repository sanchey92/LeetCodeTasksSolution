using System;
using System.Linq;

namespace LeetCodeTasks.Library
{
    public static class MakingAnagrams
    {
        public static int GetMakingAnagrams(string firstString, string secondString)
        {
            var array = new int[26];
            
            foreach (var ch in firstString)
                array[ch - 97] += 1;

            foreach (var ch in secondString)
                array[ch - 97] -= 1;

            return array.Sum(Math.Abs);
        }
    }
}