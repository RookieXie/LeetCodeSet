using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.

    You need to merge them into a new binary tree. The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of new tree.

    Example 1:

    Input: 
	    Tree 1                     Tree 2                  
              1                         2                             
             / \                       / \                            
            3   2                     1   3                        
           /                           \   \                      
          5                             4   7                  
    Output: 
    Merged tree:
	         3
	        / \
	       4   5
	      / \   \ 
	     5   4   7
 

    Note: The merging process must start from the root nodes of both trees.
     * **/
    public class MergeTwoBinaryTrees617
    {
        /// <summary>
        /// 1.不为空则值相加，为空则直接返回
        /// 2.如果t1左右子树为空，直接使用t2的左右子树，不为空重复1,2
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t2 != null)
            {
                if (t1 != null)
                {
                    t1.val = t2.val + t1.val;
                    if (t1.left != null)
                    {
                        t1.left = MergeTrees(t1.left, t2.left);
                    }
                    else
                    {
                        t1.left = t2.left;
                    }
                    if (t1.right != null)
                    {
                        t1.right = MergeTrees(t1.right, t2.right);
                    }
                    else
                    {
                        t1.right = t2.right;
                    }
                }
                else
                {
                    t1 = t2;
                }
            }                
            return t1;
        }
    }
}
