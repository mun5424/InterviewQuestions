using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class StringToInt
    {
        static int stoi(string str)
        {
            //convert a string into an integer.
            //classic problem aka atoi (array to integer) 

            int res = 0; 
            if(str.Length == 0 || str == null)
            {
                return 0; 
            }
            str = str.Trim(); 
            int sign = str[0] == '-' ? -1 : 1; 
            for(int i = 1; i < str.Length; i++)
            {
                if(!char.IsNumber(str[i]))
                    break; 
                res = res * 10 + str[i] - '0'; 
                if(res * sign > int.MaxValue) return int.MaxValue; //overflow 
                if(res * sign < int.MinValue) return int.MinValue; //overflow
            }
            return (int) sign * res; 
        }
    }
}
