using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InterviewQuestions
{
    class Node
    {
        public int key;
        public int value;
        public Node pre;
        public Node next;
        public Node(int key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class LRUCache
    {
        //Design andf implement a data structure for Least Recently Used cache. 
        // use a double linked list
        int capacity;
        Dictionary<int, Node> map = new Dictionary<int, Node>();
        Node head = null;
        Node tail = null;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int get(int key)
        {
            if (map.ContainsKey(key))
            {
                Node n = map[key];

                remove(n);
                setHead(n);
                return n.value;
            }
            return -1;
        }
        public void remove(Node n)
        {
            if (n.pre != null)
            {
                n.pre.next = n.next;
            }
            else
            {
                head = n.next;
            }
            if (n.next != null)
            {
                n.next.pre = n.pre;
            }
            else
            {
                tail = n.pre;
            }
        }


        public void setHead(Node n)
        {
            n.next = head;
            n.pre = null;

            if (head != null)
                head.pre = n;

            head = n;

            if (tail == null)
                tail = head;
        }

        public void set(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                Node old = map[key];
                old.value = value;
                remove(old);
                setHead(old);
            }
            else
            {
                Node created = new Node(key, value);
                if (map.Count >= capacity)
                {
                    map.Remove(tail.key);
                    remove(tail);
                    setHead(created);
                }
                else
                {
                    setHead(created);
                }

                map.Add(key, created);
            }
        }
    }
}