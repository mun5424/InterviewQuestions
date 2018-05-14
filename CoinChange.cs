using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class CoinChange
    {
        // problem: given an a number and an array of denominations of change (pennies, nickels, etc..) 
        // find the minimum number of coins to sum a certain number t. 
        public static int getMinimumCoinChange(int [] denom, int t)
        {
            int[] C = new int[t + 1];
            int[] S = new int[t + 1];
            int coin = 0;
            C[0] = 0; 

            for(int p = 1; p <= t; p++)
            {
                int min = Int32.MaxValue; 
                for (int i = 0; i < denom.Length; i++)
                {
                   if(denom[i] <= p)
                    {
                        if(1 + C[p-denom[i]] < min)
                        {
                            min = 1 + C[p - denom[i]];
                            coin = i;
                        }
                    }
                }
                C[p] = min;
                S[p] = coin;

            }
            Console.Write("C values => ");
            printArray(C);
            Console.WriteLine();
            Console.Write("S values => ");
            printArray(S);
            Console.WriteLine();
            int sum = t; 
            while(sum > 0)
            {
                
            }
            return C[t]; 
        }

        public static void printArray(int [] array)
        {
           for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", "); 
            }
        }

        public static void test()
        {
            int[] denom = { 1, 5, 10, 25 };
            int target = 39;
            int result = getMinimumCoinChange(denom, target);
            Console.WriteLine(result);
        }
    }
}
