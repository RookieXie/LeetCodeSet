package com.leetcode.easy;

import com.leetcode.models.TreeNode;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;

/*
*Given a binary tree, return all root-to-leaf paths.

Note: A leaf is a node with no children.

Example:

Input:

   1
 /   \
2     3
 \
  5

Output: ["1->2->5", "1->3"]

Explanation: All root-to-leaf paths are: 1->2->5, 1->3
* */
public class Binary_Tree_Paths257 {
    //思路 带有上一层的路径，碰到null list.add
    HashSet<String> hs = new HashSet<String>();

    public List<String> binaryTreePaths(TreeNode root) {
        GetPath("", root);
        List<String> list = new ArrayList<String>();
        for (String h : hs) {
            list.add(h);

        }
        return list;
    }

    public void GetPath(String prePath, TreeNode node) {
        if (node != null) {
            prePath = prePath.isEmpty() ? node.val + "" : prePath + "->" + node.val;
            if (node.left == null && node.right == null) {
                hs.add(prePath);
            }
            GetPath(prePath, node.left);
            GetPath(prePath, node.right);
        }
    }

}
