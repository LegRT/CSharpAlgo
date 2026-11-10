public class Solution {
    public int MaxProfit(int[] prices)
    {
        int first = 0;
        int second = prices.Length - 1;
        int maxProfit = 0;
        int minBuyPrice = Int32.MaxValue;

        foreach (var price in prices)
        {
            minBuyPrice = Math.Min(minBuyPrice, price);
            maxProfit = Math.Max(maxProfit, price -  minBuyPrice);
        }
        return maxProfit;
    }
}