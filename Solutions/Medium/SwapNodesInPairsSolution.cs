using Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
	public class SwapNodesInPairsSolution
	{
		public ListNode SwapPairs(ListNode head)
		{
			ListNode dummyHead = new ListNode(0, head);
			ListNode current = dummyHead;
			if (head == null || head.next == null)
			{
				return head;
			}

			while (current.next != null && current.next.next != null)
			{
				ListNode first = current.next;
				ListNode second = current.next.next;

				current.next = second;
				first.next = second.next;
				second.next = first;
				current = first;
			}
			return dummyHead.next;
		}
	}
}
