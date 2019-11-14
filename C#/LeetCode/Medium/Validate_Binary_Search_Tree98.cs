using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class Validate_Binary_Search_Tree98
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsBST(root, long.MaxValue, long.MinValue);
        }
        public bool IsBST(TreeNode treeNode, long max, long min)
        {
            if (treeNode == null) return true;
            if (treeNode.val <= min || treeNode.val >= max)
                return false;
            return IsBST(treeNode.left, treeNode.val, min) && IsBST(treeNode.right, max, treeNode.val);
        }

    }
}
