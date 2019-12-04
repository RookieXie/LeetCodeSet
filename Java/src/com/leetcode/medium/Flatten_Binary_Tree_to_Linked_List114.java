package com.leetcode.medium;

import com.leetcode.models.ListNode;
import com.leetcode.models.TreeNode;

/*
* Given a binary tree, flatten it to a linked list in-place.

For example, given the following tree:

    1
   / \
  2   5
 / \   \
3   4   6
The flattened tree should look like:

1
 \
  2
   \
    3
     \
      4
       \
        5
         \
          6
* */
public class Flatten_Binary_Tree_to_Linked_List114 {
    //1 思路：1先找到右子树  ，2然后左子树，左子树的右子树重复1
    public void flatten(TreeNode root) {
        solve(root, null);

    }

    TreeNode solve(TreeNode root, TreeNode last) {
        if (root == null) return last;
        root.right = solve(root.left, solve(root.right, last));
        root.left = null;
        return root;
    }
}
