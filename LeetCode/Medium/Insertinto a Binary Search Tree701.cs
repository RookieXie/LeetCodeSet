using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Given the root node of a binary search tree (BST) and a value to be inserted into the tree, insert the value into the BST. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.

        Note that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after insertion. You can return any of them.

        For example, 

        Given the tree:
                4
               / \
              2   7
             / \
            1   3
        And the value to insert: 5
        You can return this binary search tree:

                 4
               /   \
              2     7
             / \   /
            1   3 5
        This tree is also valid:

                 5
               /   \
              2     7
             / \   
            1   3
                 \
                  4
     * **/
    public class Insertinto_a_Binary_Search_Tree701
    {
        /// <summary>
        /// 思路 与节点判断大小，大 走右子节点  小走左子节点，直到节点为空，自己占用为止
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
            }
            else
            {
                if (root.val <= val)
                {
                    root.right=InsertIntoBST(root.right, val);
                }
                else
                {
                    root.left=InsertIntoBST(root.left, val);
                }

            }
            return root;
        }
    }
}
