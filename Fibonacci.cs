using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class Fibonacci
    {
        public static int recursive(int n)
        {
            if(n == 0 || n == 1)
                return 1; 
            return recursive(n-1) + recursive(n-2);
        }
        public static int iterative(int n)
        {
            int a = 1; 
            int b = 1;
            for(int i = 2; i < n; i ++)
            {
                int temp = b; 
                b += a; 
                a = temp;
            }

            return b; 
        }

        public static void test()
        {
            Console.WriteLine(iterative(10));
        }
    }
}