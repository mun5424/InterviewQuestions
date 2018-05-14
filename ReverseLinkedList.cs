using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class ReverseLinkedList
    {
        
        class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        
        static ListNode Reverse(ListNode head)
        {
            if(head == null) 
                return null; 
            
            ListNode prevNode = null; 
            ListNode currNode = head; 
            ListNode nextNode = null;

            while(currNode != null)
            {
                nextNode = currNode.next;
                prevNode.next = currNode; 
                currNode.next = prevNode;
                prevNode = currNode; 
                currNode = nextNode; 
            }
            return prevNode; 
        }


        static void printList(ListNode head)
        {
            ListNode curr = head; 
            while(curr != null)
            {
                Console.Write(curr.val + " "); 
                curr = curr.next; 
            }
        }
        public static void test()
        {
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(4);
            a.next = b;
            b.next = c; 
            c.next = d;
            d.next = null; 
            printList(Reverse(a));
        }

    }
}

