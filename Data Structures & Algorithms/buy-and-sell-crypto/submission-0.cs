public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i+1; j < prices.Length; j++)
            {
                int buyDate = prices[i];
                int sellDate = prices[j];
                int profit = sellDate - buyDate;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }
        return maxProfit;
    }
}
