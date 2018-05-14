using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class TwoSum
    {

        //Problem: Given a list of integers, find two integers x and y such that x + y = target value.
        //~classic interview question
 
        static int[] calculateTwoSum(int [] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>(); 
            for(int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, map[nums[i]] };
                }
                else
                    map.Add(nums[i], i); 
                
            }
            return null; 
        }

        public static void test()
        {
            int[] test1 = { 3, 5, 2, 5, 1 };
            int target = 10;
            int[] result = calculateTwoSum(test1, target);
            Console.WriteLine("Two Sum results for test1 is " + result[0] + " " + result[1]);
        }

        //follow-up - if list is sorted? 
        //use two pointers that each start from left end and right end of the list. 


    }
}
