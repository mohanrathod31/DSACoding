using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACodingProblems.ArrayProblems
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int buyprice = prices[0];
            int current_profit = 0;
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buyprice)
                    buyprice = prices[i];
                else
                {
                    current_profit = prices[i] - buyprice;
                    profit = Math.Max(current_profit, profit);
                }

            }
            return profit;
        }
    }
}
