using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMiddleSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            
            

        }
    }

    /**
 * Definition for singly-linked list.
 */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode temp = head;
            int counter = 1;

            if (temp.next == null)
            {
                return head;
            }
            else
            {
                while (temp.next != null)
                {
                    counter++;
                    temp = temp.next;
                }

                int middleNode = counter % 2;

                if (middleNode % 2 == 1 && counter != 1)
                {
                    for (int i = 1; i < counter; i++)
                    {
                        head = head.next;
                        if (i == counter / 2)
                        {
                            break;
                        }
                    }
                }
                else if (counter % 2 == 0)
                {
                    for (int i = 1; i < counter; i++)
                    {
                        head = head.next;
                        if (i == counter / 2)
                        {
                            break;
                        }
                    }
                }
                return head;
            }
        }
    }
}
