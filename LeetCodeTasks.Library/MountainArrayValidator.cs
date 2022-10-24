namespace LeetCodeTasks.Library;

public static class MountainArrayValidator
{
    public static bool GetValidation(int[] arr)
    {
        if (arr.Length < 3 || arr[0] > arr[1])
            return false;

        var isMiddle = false;

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
                return false;

            if (!isMiddle && arr[i - 1] > arr[i])
                isMiddle = true;

            if (isMiddle && arr[i - 1] < arr[i])
                return false;
        }

        return isMiddle;
    }
}