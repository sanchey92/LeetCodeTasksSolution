using System.Collections.Generic;

namespace LeetCodeTasks.Library;

public static class CheckIfExistSolution
{
    /// Given an array arr of integers, check if there exist two indices i and j such that :
    ///     i != j;
    ///     0 <= i, j < arr.length;
    ///     arr[i] == 2 * arr[j];
    public static bool GetSolution(int[] arr)
    {
        if (arr == null || arr.Length < 2) return false;

        var data = new HashSet<int>();

        foreach (var num in arr)
        {
            if (data.Contains(num * 2) || (num % 2 == 0 && data.Contains(num / 2)))
                return true;

            data.Add(num);
        }

        return false;
    }
}