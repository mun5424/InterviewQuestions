using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class MultipleOccurrence
    {
        private static List<int> findMultipleOccurrence(int [] nums)
        {   // problem: in a list of integers, find a list of integers that occurs multiple times.
            // im actually upset that this came up in one of my interviews and i did not have a 100% bug-free solution.
            // What other way is there than using a HashSet? 
            List<int> res = new List<int>();
            var map = new HashSet<int>(); //use a map if you were to list the number of occurrences 
       
            for(int i = 0; i < nums.Length; i ++ )
            {
                int num = nums[i]; 
                if (!map.Contains(num))
                    map.Add(num);
                else
                {
                    if (!res.Contains(num))
                        res.Add(num);
                }
            } 

            return res; 
        }


        public static void test()
        {
            int [] nums = { 4, 5, 2, 1, 2, 4, 2, 3 };
            List<int> res = findMultipleOccurrence(nums); 

        }
    }
}
