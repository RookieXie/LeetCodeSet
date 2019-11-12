using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Given a binary tree, find its maximum depth.

    The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

    Note: A leaf is a node with no children.

    Example:

    Given binary tree [3,9,20,null,null,15,7],

        3
       / \
      9  20
        /  \
       15   7
    return its depth = 3.
     * **/
    public class Maximum_Depth_of_Binary_Tree104
    {
        //递归，左 右 各自统计 比较取最大值
        public int MaxDepth(TreeNode root)
        {
            return Depth(root, 0);
        }
        public int Depth(TreeNode treeNode,int i)
        {
            
            if (treeNode == null) return i;
            i++;
            int depth = i;         
            if (treeNode.left != null)
            {
                depth = Depth(treeNode.left, i);
            }
            if (treeNode.right != null)
            {
                depth = Math.Max (Depth(treeNode.right, i), depth);
            }
            return depth;
        }
    }
}
