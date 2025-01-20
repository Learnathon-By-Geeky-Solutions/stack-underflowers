// Leetcode 121.Best time to buy and sell stock

public class Solution {
    public int MaxProfit(int[] prices) {
        int mp = 0;
        int minPrice = int.MaxValue;
        foreach (int price in prices) {
            if (price < minPrice) {
                minPrice = price;
            }
            int profit = price - minPrice;
            if (profit > mp) {
                mp = profit;
            }
        }
        return mp;
    }
}