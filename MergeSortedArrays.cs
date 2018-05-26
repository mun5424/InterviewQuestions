using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class MergeSortedArrays
    {
        //given two sorted arrays A and B, merge them in sorted order.
        //assume that A has additonal space to hold B
        public static int[] sortArrays(int [] a, int [] b)
        {
            int m = a.Length;
            int n = b.Length; 

            //sort the arrays backwards to ensure no array index is overwritten
            while(m > 0 && n > 0)
            {
                if(a[m-1] > b[n-1])
                {
                    a[m+n-1] = a[m-1]; 
                    m--; 
                }
                else
                {
                    a[m+n-1] = b[n-1]; 
                    n--; 
                }
            }
            return a;
        }
    }
}
