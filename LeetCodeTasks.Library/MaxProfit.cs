using System;
using System.Collections.Generic;

namespace LeetCodeTasks.Library
{
    public static class MaxProfit
    {
        public static int FindMaxProfit(List<int> prices)
        {
            var maxProfit = 0;
            var currentMin = prices[0];

            foreach (var price in prices)
            {
                maxProfit = Math.Max(maxProfit, price - currentMin);
                currentMin = Math.Min(currentMin, price);
            }
            
            return maxProfit;
        }
    }
}