package com.leetcode.easy;

import com.leetcode.models.TreeNode;

/*
* Given a binary tree, find its minimum depth.

    The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

    Note: A leaf is a node with no children.

    Example:

    Given binary tree [3,9,20,null,null,15,7],

        3
       / \
      9  20
        /  \
       15   7
    return its minimum depth = 2.*/
public class Minimum_Depth_of_Binary_Tree111 {
    //思路： 如果左右子树有一个为null,+1 之后取其中最大值，否则 +1之后取其中最小值
    public int minDepth(TreeNode root) {
        if (root == null)
            return 0;
        int l = minDepth(root.left);
        int r = minDepth(root.right);
        return (l == 0 || r == 0) ? Math.max(l + 1, r + 1) : Math.min(l + 1, r + 1);
    }
}
