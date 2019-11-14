package com.leetcode;

import com.leetcode.medium.Validate_Binary_Search_Tree98;
import com.leetcode.models.TreeNode;

public class Main {

    public static void main(String[] args) {
        // write your code here
        System.out.println("Hello World!");
        TreeNode root = new TreeNode(0);
        Validate_Binary_Search_Tree98 validate_binary_search_tree98 = new Validate_Binary_Search_Tree98();
        boolean res = validate_binary_search_tree98.isValidBST(root);
        System.out.println(res);

    }
}
