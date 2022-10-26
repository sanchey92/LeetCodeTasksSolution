namespace LeetCodeTasks.Library;

public static class ReplaceElementsSolution
{
    public static int[] ReplaceElements(int[] arr)
    {
        if (arr.Length == 1)
            arr[0] = -1;
        
        var i = arr.Length - 2;
        var max = arr[^1];

        while (i >= 0)
        {
            var temp = arr[i];
            arr[i] = max;

            if (max < temp)
                max = temp;

            i--;
        }

        arr[^1] = -1;

        return arr;
    }
}