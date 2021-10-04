namespace LeetCodeTasks.Library
{
    public static class BinarySearchLetter
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            var left = 0;
            var right = letters.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                if (letters[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return letters[left % letters.Length];
        }
    }
}