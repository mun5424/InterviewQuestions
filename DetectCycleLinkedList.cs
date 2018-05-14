using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class DetectCycleLinkedList
    {
        class ListNode
        {
            //public scoping is bad and you should feel bad 
            //only for testing 
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        static ListNode DetectCycle(ListNode head)
        {
            //edge case  
            // 1. no list
            // 2. 1 item in list
            if (head == null ||  head.next == null)
                return null; 
            //return beginning node of the cycle
            ListNode walker = head;
            ListNode runner = head;

            while(runner != null && runner.next != null)
            {
                walker = walker.next;
                if (runner.next == null)
                    return null; 
                runner = runner.next.next;

                if(walker.val == runner.val)
                {
                    //found the cycle. however, walker is not at the beginning of the cycle. 
                    //keep iterating from the beginning to get the beginning node of the cycle. 
                    ListNode walker2 = head; 
                    while(walker2.val != walker.val)
                    {
                        walker2 = walker2.next;
                        walker = walker.next;
                    }
                    return walker; 
                }
            }
            return null; 
            
        }


        public static void test()
        {
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(4);
            ListNode e = new ListNode(5);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = c;// a => b => c=> d => e => c 
            ListNode n = DetectCycle(a);
            Console.WriteLine("The Linked List has a cycle starting at " + n.val); 
        

        }
    }
}
