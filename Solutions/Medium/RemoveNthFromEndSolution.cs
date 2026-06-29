using Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
    public class RemoveNthFromEndSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;
            ListNode fast = dummyHead;
            ListNode slow = dummyHead;
            int i = 0;
            while (fast.next != null)
            {
                if (i >= n)
                {
                    slow = slow.next;
                }

                fast = fast.next;
                i++;
            }
            slow.next = slow.next.next;
            return dummyHead.next;
        }
    }
}
