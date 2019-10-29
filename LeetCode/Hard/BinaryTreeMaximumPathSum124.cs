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
            return Math.Max(left, right) + root.val;
        }
    }
}
