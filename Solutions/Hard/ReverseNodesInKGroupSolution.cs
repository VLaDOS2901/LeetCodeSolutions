using Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Hard
{
	public class ReverseNodesInKGroupSolution
	{
		public ListNode ReverseKGroup(ListNode head, int k)
		{
			ListNode dummyHead = new ListNode(0, head);
			ListNode current = dummyHead;
			if (head == null || head.next == null)
			{
				return head;
			}

			while (true)
			{
				ListNode tail = current;
				for (int i = 0; i < k; i++)
				{
					if (tail.next == null) 
						return dummyHead.next; 
					
					tail = tail.next;
				}

				ListNode groupStart = current.next;
				ListNode prev = null;
				ListNode curr = groupStart;

				for (int i = 0; i < k; i++)
				{
					ListNode nextTemp = curr.next;
					curr.next = prev;
					prev = curr;
					curr = nextTemp;
				}

				current.next = prev;
				groupStart.next = curr;
				current = groupStart;
			}

			return dummyHead.next;
		}
	}
}
