using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val >= l2.val)
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
            else
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode _list = head;
            ListNode _list2 = head;
            //int i = 0;
            //while (_list.next != null)
            //{
            //    i++;
            //    _list = _list.next;
            //}
            //_list = head;
            //for (int j = 0; j <=i-n; j++)
            //{
            //    _list = _list.next;
            //}
            //int k = 0;
            //while (_list2.next != _list)
            //{
            //    _list2 = _list2.next;
            //    k++;
            //}
            //_list2.next = _list.next;
            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
   
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
}
