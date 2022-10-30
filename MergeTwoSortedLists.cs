//21. Merge Two Sorted Lists
using System;

namespace MergeTwoSortedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }

        /*The key to solve the problem is defining a fake head. Then compare the first elements from each list. 
         * Add the smaller one to the merged list. Finally, when one of them is empty, simply append it to the merged list, since it is already sorted.
        */
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode(0);
            ListNode p = head;

            ListNode p1 = list1;
            ListNode p2 = list2;
            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    p.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    p.next = p2;
                    p2 = p2.next;
                }
                p = p.next;
            }

            if (p1 != null)
            {
                p.next = p1;
            }

            if (p2 != null)
            {
                p.next = p2;
            }

            return head.next;

        }
    }
}
