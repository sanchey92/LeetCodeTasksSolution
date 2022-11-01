using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks.Library;

public static class HeightsCheckerSolution
{
    public static int CheckHeights(int[] heights)
    {
        var expected = new List<int>(heights);
        expected.Sort();
        
        return heights.Where((t, i) => t != expected[i]).Count();
    }
}