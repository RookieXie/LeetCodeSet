using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Given two binary trees, write a function to check if they are the same or not.

    Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

    Example 1:

    Input:     1         1
              / \       / \
             2   3     2   3

            [1,2,3],   [1,2,3]

    Output: true
    Example 2:

    Input:     1         1
              /           \
             2             2

            [1,2],     [1,null,2]

    Output: false
    Example 3:

    Input:     1         1
              / \       / \
             2   1     1   2

            [1,2,1],   [1,1,2]

    Output: false
     * **/
    public class Same_Tree100
    {
        ///思路，每一个一个节点验证是否相等，或者是否都为空
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            bool res = false;
            if (p == null && q == null)
            {
                res = true;
            }else if (p == null || q == null)
            {
                res = false;
            }
            else if (p.val == q.val)
            {

                res = IsSameTree(p.left, q.left);
                if (res)
                {
                    res = IsSameTree(p.right, q.right);
                }

            }
            return res;
        }
    }
}
