namespace LeetCodeTasks.Library;

/// <summary>
/// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n,
/// representing the number of elements in nums1 and nums2 respectively.
/// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
/// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
/// To accommodate this, nums1 has a length of m   n, where the first m elements denote the elements that should be
/// merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
/// </summary>
public static class MergeSortedSolution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var index1 = m - 1;
        var index2 = n - 1;
        var length = m + n - 1;

        while (index1 >= 0 && index2 >= 0)
        {
            if (nums1[index1] > nums2[index2])
            {
                nums1[length] = nums1[index1];
                index1--;
            }
            else
            {
                nums1[length] = nums2[index2];
                index2--;
            }

            length--;
        }

        while (index2 >= 0)
        {
            nums1[length] = nums2[index2];
            index2--;
            length--;
        }
    }
}