using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    /**
     * Given a non-empty binary tree, find the maximum path sum.

    For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. The path must contain at least one node and does not need to go through the root.

    Example 1:

    Input: [1,2,3]

           1
          / \
         2   3

    Output: 6
    Example 2:

    Input: [-10,9,20,null,null,15,7]

       -10
       / \
      9  20
        /  \
       15   7

    Output: 42
     * **/
    public class BinaryTreeMaximumPathSum124
    {
        /// <summary>
        /// 题意理解：1.一个树，左右子节点与0对比取最大值，然后与父节点相加再与最大值比较取最大值，返回左右子树的最大值与父节点相加的值
        /// 2.递归处理 循环1 操作
        /// </summary>
        public int max = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            MaxPathSum2(root);

            return max;
        }
        public int MaxPathSum2(TreeNode root)
        {
            if (root == null) return 0;
            int left = Math.Max(0, MaxPathSum2(root.left));
            int right = Math.Max(0, MaxPathSum2(root.right));
            max = Math.Max(max, left + right + root.val);
            //这一步返回值关键 表示 父节点的父节点如果往下走到父节点 只能走父节点和左右子节点的其中一个（所以比较最大值）
            return Math.Max(left, right) + root.val;
        }
    }
}
