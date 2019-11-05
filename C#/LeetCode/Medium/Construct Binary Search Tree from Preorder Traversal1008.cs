using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Return the root node of a binary search tree that matches the given preorder traversal.

(Recall that a binary search tree is a binary tree where for every node, any descendant of node.left has a value < node.val, and any descendant of node.right has a value > node.val.  Also recall that a preorder traversal displays the value of the node first, then traverses node.left, then traverses node.right.)

 

Example 1:

Input: [8,5,1,7,10,12]
Output: [8,5,10,1,7,null,12]

 

Note: 

1 <= preorder.length <= 100
The values of preorder are distinct.
     * **/
    public class Construct_Binary_Search_Tree_from_Preorder_Traversal1008
    {
        /// <summary>
        ///遍历数组，每次跟已有的树从根节点开始比对
        /// </summary>
        /// <param name="preorder"></param>
        /// <returns></returns>
        public TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode treeNode = new TreeNode(preorder[0]);
            for (int i = 1; i < preorder.Length; i++)
            {
                treeNode=Bst(treeNode, preorder[i]);
            }
            return treeNode;
        }
        public TreeNode Bst(TreeNode treeNode, int value)
        {
            if (treeNode == null)
            {
                return new TreeNode(value);
            }
            if (treeNode.val < value)
            {
                treeNode.right=Bst(treeNode.right, value);
            }
            else
            {
                treeNode.left=Bst(treeNode.left, value);
            }
            return treeNode;
        }
    }
}
