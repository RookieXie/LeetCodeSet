using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

    Note: A leaf is a node with no children.

    Example:

    Given the below binary tree and sum = 22,

          5
         / \
        4   8
       /   / \
      11  13  4
     /  \      \
    7    2      1
    return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.**/
    public class Path_Sum112
    {
        /// <summary>
        /// 思路，1.判断节点是否为null 是否 返回false  2. 如果是leaf ，sum-val==0; 3 不是leaf 左右子树迭代1,2步骤，左右一个为true即可
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            sum -= root.val;            
            if (root.left == null && root.right == null)
            {
                return sum==0;
            }
            else
            {
                return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
            }
        }
    }
}
