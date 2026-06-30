using Solutions.Easy;
using Solutions.Medium;
using Solutions.Models;
using System.Text.Json;

namespace Solutions
{
    public class Solution
    {
        public int[] TwoSumTwo(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return Array.Empty<int>();

            int left = 0;
            int right = nums.Length-1;
            if (nums != null)
            {
                while (left < right)
                {
                    if (nums[left] + nums[right] == target)
                    {
                        return [left+1, right+1];
                    }
                    else if (nums[left] + nums[right] < target)
                        left++;
                    else
                        right--;
                }
            }
            return Array.Empty<int>();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region TwoPairs
            //TwoSumSolution twoSum = new TwoSumSolution();
            //twoSum.TwoSum([3, 2 , 4], 6);
            #endregion

            #region AddTwoNumbers ListNode
            //ListNode l1 = new ListNode(2);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //AddTwoNumbersSolution addTwoNumbers = new AddTwoNumbersSolution();
            //ListNode l3 = addTwoNumbers.AddTwoNumbers(l1, l2);
            //while (l3 != null)
            //{
            //    Console.WriteLine(l3.val);
            //    l3 = l3.next;
            //}
            #endregion

            #region LengthOfLongestSubstring
            //LongestSubstringSolution longestSubstring = new LongestSubstringSolution();
            //Console.WriteLine(longestSubstring.LengthOfLongestSubstring("pwwkew"));
            #endregion

            #region Palindrome Number
            //IsPalindromeSolution isPalindrome = new IsPalindromeSolution();
            //Console.WriteLine(isPalindrome.IsPalindrome(11));
            #endregion

            #region Longest Common Prefix
            //LongestCommonPrefixSolution longestCommonPrefix = new LongestCommonPrefixSolution();
            //Console.WriteLine(longestCommonPrefix.LongestCommonPrefix(["dog", "racecar", "car"]));
            #endregion

            #region TwoSumTwo
            //int[] answ = solution.TwoSumTwo([2, 7, 11, 15], 9);
            #endregion

            #region FourSum
            //FourSumSolution fourSum = new FourSumSolution();
            //Console.WriteLine(JsonSerializer.Serialize(fourSum.FourSum([2,2,2,2,2], 8)));
            #endregion

            #region remove nth from end
            //RemoveNthFromEndSolution removeNthFromEnd = new RemoveNthFromEndSolution();
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            //ListNode result = removeNthFromEnd.RemoveNthFromEnd(head, 2);
            //while (result != null)
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}
            #endregion

            #region isValid (){}[]
            //ValidParenthesesSolution validParentheses = new ValidParenthesesSolution();
            //Console.WriteLine(validParentheses.IsValid("()"));
            #endregion

            #region Merge Two Lists
            MergeTwoListsSolution mergeTwoLists = new MergeTwoListsSolution();
            ListNode listNode1 = new ListNode(1);
            listNode1.next = new ListNode(2);
            listNode1.next.next = new ListNode(4);
            ListNode listNode2 = new ListNode(1);
            listNode2.next = new ListNode(3);
            listNode2.next.next = new ListNode(4);
            ListNode result = mergeTwoLists.MergeTwoLists(listNode1, listNode2);
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            #endregion
        }
    }
}
