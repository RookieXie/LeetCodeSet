package com.leetcode.medium;

import com.leetcode.models.TreeNode;

/*
* Given a binary tree, determine if it is a valid binary search tree(BST).

Assume a BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.


Example 1:

    2
   / \
  1   3

Input: [2,1,3]
Output: true
Example 2:

    5
   / \
  1   4
     / \
    3   6

Input: [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
* [3,1,5,0,2,4,6,null,null,null,3]
[2147483647]
* */
public class Validate_Binary_Search_Tree98 {
    public boolean isValidBST(TreeNode root) {
        return isBST(root, Long.MAX_VALUE, Long.MIN_VALUE);
    }

    public boolean isBST(TreeNode treeNode, long max, long min) {
        if (treeNode == null) return true;
        if (treeNode.val <= min || treeNode.val >= max)
            return false;
        return isBST(treeNode.left, treeNode.val, min) && isBST(treeNode.right, max, treeNode.val);
    }
}
