using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
   public  class Flatten_Binary_Tree_to_Linked_List114
    {
        public void flatten(TreeNode root)
        {
            TreeNode newNode = root;
            while (newNode != null)
            {
                root = new TreeNode(newNode.val);
                root.left = null;
                root = root.right;
                if (newNode.left != null)
                {
                    newNode = newNode.left;
                }
                else
                {
                    newNode = newNode.right;
                }
            }

        }
    }
}
