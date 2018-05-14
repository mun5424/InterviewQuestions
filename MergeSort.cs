using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InterviewQuestions
{
    class MergeSort
    {
        //Problem: implement a MergeSort (for sorting integers for the sake of simplicity) 
 
        static int[] mergeSort(int[] nums)
        {
            // divide and conquer 
            mergeHelper(nums, 0, nums.Length - 1);
            return nums;
        }

        static void mergeHelper(int[] n, int l, int r)
        {
            int mid;
            if (r > l)
            {
                //Console.WriteLine(n + " " + l + " " + r);
                mid = (r + l) / 2;
                mergeHelper(n, l, mid);
                mergeHelper(n, (mid + 1), r);
                merge(n, l, r, (mid + 1));
            }
        }

        static void merge(int[] n, int l, int r, int m)
        {
            // Invariant is that
            // Precondition: l < m < r; n[l..m] and n[m..r] are sorted
            // Postcondition: n[l..r] is sorted

            int[] result = new int[n.Length];
            int lIdx = l;
            int rIdx = m;
            int scanIdx = l;
            int elements = r - l + 1;
            while (lIdx < m && rIdx <= r)
            {
                if (n[lIdx] < n[rIdx])
                {
                    result[scanIdx++] = n[lIdx++];
                }
                else
                {
                    result[scanIdx++] = n[rIdx++];
                }
            }
            while (lIdx < m)
            {
                result[scanIdx++] = n[lIdx++];
            }
            while (rIdx <= r)
            {
                result[scanIdx++] = n[rIdx++];
            }

            //printer("left value was " + l + " right value was " + r + " with element count " + elements); 
            for (int i = 0; i < elements; i++)
            {
                n[r] = result[r];
                r--;
            }

        }


        public static void test()
        {
            Debug.WriteLine("Test MergeSort ");
            Debug.WriteLine("");
            int[] nums = new int[] { 1, 5, 3, 6,7};
            //ergeSort(nums);
            Debug.WriteLine((string.Join(",", mergeSort(nums))));

            nums = new int[] { };
            mergeSort(nums);
            Debug.WriteLine((string.Join(",", nums)));

            nums = new int[] { 3, 2, 1 };
            mergeSort(nums);
            Debug.WriteLine((string.Join(",", nums)));

            nums = new int[] { 1, 2, 3, -1 };
            mergeSort(nums);
            Debug.WriteLine((string.Join(",", nums))); 

            nums = new int[] { 1, 3, 2, 4 };
            mergeSort(nums);
            Debug.WriteLine((string.Join(",", nums)));
        }
    }
}
    

