namespace LeetCodeTasks.Library
{
    public static class ArrayLeftRotation
    {
        public static int[] GetLeftRotation(int[] array, int shift)
        {
            var length = array.Length;
            var newArray = new int[length];

            for (var i = 0; i < length; i++)
            {
                var index = i - shift;
                var place = length + index;

                if (index >= 0)
                {
                    newArray[index] = array[i];
                }
                else
                {
                    newArray[place] = array[i];
                }
            }
            
            return newArray;
        }
    }
}