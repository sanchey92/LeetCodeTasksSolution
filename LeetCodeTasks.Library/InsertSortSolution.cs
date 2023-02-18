namespace LeetCodeTasks.Library;

public static class InsertSortSolution
{
    public static void DoSort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var current = array[i];
            var j = i;
            while (j > 0 && current < array[j - 1])
            {
                array[j] = array[j - 1];
                j--;
            }

            array[j] = current;
        }
    }

}