namespace LeetCodeTasks.Library
{
    public static class ClimbingStairs
    {
        public static int FindClimbingStairs(int n)
        {
            if (n <= 2) return n;

            var res = new int[n + 1];

            res[1] = 1;
            res[2] = 2;

            for (var i = 3; i <= n; i++)
                res[i] = res[i - 1] + res[i - 2];

            return res[n];
        }
    }
}