using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

        For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

            1
           / \
          2   2
         / \ / \
        3  4 4  3
 

        But the following [1,2,2,null,3,null,3] is not:

            1
           / \
          2   2
           \   \
           3    3
 

        Note:
        Bonus points if you could solve it both recursively and iteratively.
     * **/
    public class Symmetric_Tree101
    {
        public bool IsSymmetric(TreeNode root)
        {
            bool res = true;
            if (root != null)
            {
                res = Chcek(root.left, root.right);
            }
            return res;
        }
        public bool Chcek(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;

            return left != null && right != null && left.val == right.val && Chcek(left.left, right.right) && Chcek(left.right, right.left);

        }
    }
}
