using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class Validate_Binary_Search_Tree98
    {
        public bool isValidBST(TreeNode root)
        {
            return isBST(root, long.MaxValue, long.MinValue);
        }
        public bool isBST(TreeNode treeNode, long max, long min)
        {
            if (treeNode == null) return true;
            if (treeNode.val <= min || treeNode.val >= max)
                return false;
            return isBST(treeNode.left, treeNode.val, min) && isBST(treeNode.right, max, treeNode.val);
        }

    }
}
