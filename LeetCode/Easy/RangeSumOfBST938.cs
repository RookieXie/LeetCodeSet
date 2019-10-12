using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).
    /// The binary search tree is guaranteed to have unique values.
    /// 1. binary search tree  二叉查找树结构
    /// 2. 遍历 二叉树 
    /// 3. 比对 L  R 值 
    /// 4. 符合条件进行sum
    /// </summary>
    public class RangeSumOfBST938
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root != null)
            {
                if(root.val>=L && root.val <= R)
                {
                    sum += root.val;
                }
                if (root.left != null )
                {
                    sum += RangeSumBST(root.left, L, R);
                }
                if (root.right != null)
                {
                    sum += RangeSumBST(root.right, L, R);
                }
            }
            return sum;
        }
        //优化  利用二叉树性质 left小于root  right 大于 root
        //若其左子树存在，则其左子树中每个节点的值都不大于该节点值；
        //若其右子树存在，则其右子树中每个节点的值都不小于该节点值。
        public int RangeSumBST2(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root != null)
            {
                if (root.val >= L && root.val <= R)
                {
                    sum += root.val;
                }
                if (root.left != null && root.val > L)
                {
                    sum += RangeSumBST(root.left, L, R);
                }
                if (root.right != null && root.val < R)
                {
                    sum += RangeSumBST(root.right, L, R);
                }
            }
            return sum;
        }
    }
}
