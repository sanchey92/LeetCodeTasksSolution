using System.Linq;

namespace LeetCodeTasks.Library
{
    public static class DuplicateZeros
    {
        public static void AddZeros(int[] arr)
        {
            var zeroes = 0;
            var originalLen = arr.Length;

            for (var i = 0; i < arr.Length; i++)
                if (arr[i] == 0) zeroes++;

            var extendedLen = originalLen + zeroes;

            for (int i = originalLen - 1, j = extendedLen - 1; i < j; i--, j--)
            {
                if (arr[i] != 0) 
                {
                    if (j < originalLen)
                        arr[j] = arr[i];
                }
                else //Copy zero twice 
                {
                    if (j < originalLen)
                        arr[j] = arr[i];
                    j--;
                    if (j < originalLen)
                        arr[j] = arr[i]; 
                }
            }
        }
    }
}