package com.leetcode;

import com.leetcode.easy.Valid_Perfect_Square367;
import com.leetcode.medium.Validate_Binary_Search_Tree98;
import com.leetcode.models.TreeNode;

import java.util.Arrays;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        // write your code here
//        System.out.println("Hello World!");
//        TreeNode root = new TreeNode(0);
//        Validate_Binary_Search_Tree98 validate_binary_search_tree98 = new Validate_Binary_Search_Tree98();
//        boolean res = validate_binary_search_tree98.isValidBST(root);
//        System.out.println(res);
//        int[] myArray = { 1, 2, 3 };
//        List myList = Arrays.asList(myArray);
//        System.out.println(myList.size());//1
//        System.out.println(myList.get(0));//数组地址值
//        System.out.println(myList.get(1));//报错：ArrayIndexOutOfBoundsException
//        int [] array=(int[]) myList.get(0);
//        System.out.println(array[0]);//1
        Valid_Perfect_Square367 square367=new Valid_Perfect_Square367();
        boolean res=square367.isPerfectSquare(15);
        boolean res1=square367.isPerfectSquare(9);
        boolean res2=square367.isPerfectSquare(16);
        System.out.println(res);
        System.out.println(res1);
        System.out.println(res2);


    }
}
