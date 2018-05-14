using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class LongestCommonSubsequence
    {
        //problem: find longest common subsequence between two strings. "aaabbccca", "bacabbca" => "bbc"
        //classic dynamic programming problem
        private static string LCS(string a, string b)
        {
            int m = a.Length + 1;
            int n = b.Length + 1;
            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else
                    {
                        if (a[i - 1] == b[j - 1])
                            dp[i, j] = dp[i - 1, j - 1] + 1;
                        else
                            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            //traverse the array backwards to find the answer string 
            StringBuilder str = new StringBuilder();
            int index = dp[m-- - 1, n-- - 1];
            char[] result = new char[index--];
            while (m >= 0 && n >= 0 && index >= 0)
            {
                if(a[m-1] == b[n-1])
                {
                    result[index--] = a[m - 1];
                    m--;
                    n--;
                }
                else if (dp[m - 1, n] > dp[m, n - 1])
                    m--;
                else
                    n--;
            }


            return new string(result); 
        }


        public static void test()
        {
            string a = "askldsaldasavvsaab";
             string b =  "avvsaba";

            Console.WriteLine("LCS for " + a + " " + b + " => " + LCS(a, b)); 

        }
    }
}
