package com.leetcode.medium;

import com.leetcode.models.ListNode;
import com.leetcode.models.TreeNode;

import java.util.ArrayList;
import java.util.List;

/*Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.

For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

Example:

Given the sorted linked list: [-10,-3,0,5,9],

One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:

      0
     / \
   -3   9
   /   /
 -10  5
* */
public class Convert_Sorted_List_to_Binary_Search_Tree109 {
    //思路：1.先将listnode 遍历到list中，2.然后再去中间值， 3.左边归左子树，右边归右子树，重复2
    public TreeNode sortedListToBST(ListNode head) {
        List<Integer> list=new ArrayList<Integer>();
        getNums(head,list);
        return getTree(list,0,list.size());
    }
    public TreeNode getTree(List<Integer> nums,int start,int end){
        if(start>=end) return null;
        int mid=start+(end-start)/2;
        TreeNode node=new TreeNode(nums.get(mid));
        node.left=getTree(nums,start,mid);
        node.right=getTree(nums,mid+1,end);
        return node;
    }
    public  void getNums(ListNode head,List<Integer> list){
        if(head!=null){
            list.add(head.val);
            getNums(head.next,list);
        }
    }

}
