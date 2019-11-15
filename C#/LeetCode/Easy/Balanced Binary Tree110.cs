using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**Given a binary tree, determine if it is height-balanced.

    For this problem, a height-balanced binary tree is defined as:

    a binary tree in which the left and right subtrees of every node differ in height by no more than 1.

 

    Example 1:

    Given the following tree [3,9,20,null,null,15,7]:

        3
       / \
      9  20
        /  \
       15   7
    Return true.

    Example 2:

    Given the following tree [1,2,2,3,3,null,null,4,4]:

           1
          / \
         2   2
        / \
       3   3
      / \
     4   4
    Return false. [1,2,2,3,null,null,3,4,null,null,4]
     * **/
    public class Balanced_Binary_Tree110
    {
        //解析 左右子树相差高度不超过1
        /*
         思路：从最低算起，为空返回0，不为空的，获取左右子树高度，如果有-1 直接返回-1 ，没有判断相差高度，超过1 返回-1 否则返回最大值+1
             */
        public bool IsBalanced(TreeNode root)
        {
            return TreeDepth(root) != -1;
        }
        public int TreeDepth(TreeNode treeNode)
        {
            if (treeNode == null) return 0;
            int left = TreeDepth(treeNode.left);
            int right = TreeDepth(treeNode.right);

            return left != -1 && right != -1 && Math.Abs(left - right) <= 1 ? Math.Max(left, right) + 1 : -1;
        }
    }
}
