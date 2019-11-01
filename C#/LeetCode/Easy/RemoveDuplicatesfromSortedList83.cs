using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /*
     Given a sorted linked list, delete all duplicates such that each element appear only once.
         */
    public class RemoveDuplicatesfromSortedList83
    {
        /// <summary>
        /// 考虑去重 就是遍历，下一个值是否存在，是 下下一个替换下一个，再判断下一个；如果下一个不存在，下一个替换当前
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            HashSet<int> pairs = new HashSet<int>();

            ListNode node = head;
            if (node != null)
                pairs.Add(node.val);
            while (node != null)
            {

                if (node.next != null)
                {
                    if (pairs.Contains(node.next.val))
                    {
                        node.next = node.next.next; //删除重复
                    }
                    else
                    {
                        pairs.Add(node.next.val);
                        node = node.next;
                    }
                }
                else
                {
                    node = node.next;
                }
            }

            return head;
        }
        /// <summary>
        /// 思路相同，只是第一次没考虑已经排序完成
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates2(ListNode head)
        {
            ListNode node = head;
            while (node != null)
            {

                if (node.next != null)
                {
                    if (node.val==node.next.val)
                    {
                        node.next = node.next.next; //删除重复
                    }
                    else
                    {
                        node = node.next;
                    }
                }
                else
                {
                    node = node.next;
                }
            }

            return head;
        }
    }
}
