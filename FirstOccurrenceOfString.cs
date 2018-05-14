using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class FirstOccurrenceOfString
    {
        //find the first occurrence of string y in string x.
        //classic interview question - use Knuth-Morris-Pratt Algorithm 
        //holy shit why is kmp so hard to understand 

        private static int firstOccurrenceOfString(string pattern, string text)
        {
            int[] failure = failureFunction(pattern);

            int j = 0;
            int i = 0; 

            while(i < text.Length)
            {
                if(pattern[j] == text[i])
                {
                    i++;
                    j++; 
                }
                if(j == pattern.Length)
                {
                    return j; 
                }
                else if(i < text.Length && pattern[j] != text[i])
                {
                    if (j != 0)
                        j = failure[j - 1];
                    else
                        i = i + 1; 
                }
                
            }
            return -1; 
        }

        private static int[] failureFunction(string pattern)
        {
            int j = 0;
            int length = pattern.Length;
            int [] res = new int[length] ;
            res[0] = 0;
            int i = 1; 
            while(i < length)
            {
                if (pattern[i] == pattern[j])
                {
                    j++;
                    res[i] = j;
                    i++; 
                }
                else
                {
                    if (j != 0)
                        j = res[j - 1];
                    else
                    {   //j == 0
                        res[i] = 0;
                        i++;
                    }
                       
                }
            }

            return res; 
            //construct a failure function array
        }
    
    }
}
