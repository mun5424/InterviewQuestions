using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class BuyingStocks
    {
        //given an array where each index marks a day of a stock value.
        //find the maximum value of the profit you can gain from buying and selling from the array. 
        //ex: [7,1,5,3,6,4]
        //Output: 5

        public int MaxProfit(int[] prices)
        {
            if(prices.Length <= 1)
                return 0; 
            int min = prices[0];
            int result = 0;
            
            for(int i =1; i < prices.Length; i++)
            {
                result = Math.Max(result, prices[i]-min); 
                min = Math.Min(min, prices[i]); 
            }
            return result; 
        }
    }
}