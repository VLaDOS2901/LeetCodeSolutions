using Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Hard
{
    public class MergeKSortedListsSolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            var nodeList = new List<ListNode>(lists);

            while(nodeList.Count > 1)
            {
                var merged = MergeTwoLists(nodeList[0], nodeList[1]);
                nodeList.RemoveRange(0, 2);
                nodeList.Add(merged);
            }
            return nodeList[0];
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode current = dummyHead;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else if (list1.val > list2.val)
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            current.next = list1 ?? list2;
            return dummyHead.next;
        }
    }
}
