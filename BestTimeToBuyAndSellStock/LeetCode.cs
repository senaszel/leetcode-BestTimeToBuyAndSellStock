using System.Collections.Generic;
using System.Linq;

namespace BestTimeToBuyAndSellStock
{
    public class LeetCode
    {
        public static int MaxProfit(int[] prices)
        {
            int diff = 0;

            Dictionary<int, int> buyDict = new Dictionary<int, int>();
            Dictionary<int, int> sellDict = new Dictionary<int, int>();

            int buy = int.MaxValue;
            int sell = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= buy)
                {
                    buyDict.Add(i, prices[i]);
                    buy = prices[i];
                }
                else
                {
                    sellDict.Add(i, prices[i]);
                    sell = prices[i];
                    KeyValuePair<int, int> outcomeBuy = buyDict.OrderBy(b => b.Value).FirstOrDefault(b => b.Value == buyDict.Values.Min());
                    KeyValuePair<int, int> outcomeSell = sellDict.OrderByDescending(s => s.Value).FirstOrDefault(s => s.Key > outcomeBuy.Key);
                    int outcomeDiff = outcomeSell.Value - outcomeBuy.Value;
                    diff = (outcomeDiff > diff) && (outcomeDiff >= 0) ? outcomeDiff : diff;
                }
            }
            int outcome = diff > 0 ? diff : 0;
            return outcome;
        }
    }
}