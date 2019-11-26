package com.leetcode.easy;

import com.leetcode.models.TreeNode;

/*
* Given an array where elements are sorted in ascending order, convert it to a height balanced BST.

For this problem, a height-balanced binary tree is defined as a binary tree in which
the depth of the two subtrees of every node never differ by more than 1.

Example:

Given the sorted array: [-10,-3,0,5,9],

One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:

      0
     / \
   -3   9
   /   /
 -10  5
* */
public class Convert_Sorted_Array_to_Binary_Search_Tree108 {
    //每次取中间值，左边归左子树 右边归子树，重复
    public TreeNode sortedArrayToBST(int[] nums) {
        return getTree(nums, 0, nums.length);
    }

    public TreeNode getTree(int[] nums, int start, int end) {
        if (start >= end) {
            return null;
        }
        int mid = start + (end - start) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = getTree(nums, start, mid);
        node.right = getTree(nums, mid + 1, end);
        return node;
    }
}
