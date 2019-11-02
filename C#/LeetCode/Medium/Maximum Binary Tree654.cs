using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Given an integer array with no duplicates. A maximum tree building on this array is defined as follow:

    The root is the maximum number in the array.
    The left subtree is the maximum tree constructed from left part subarray divided by the maximum number.
    The right subtree is the maximum tree constructed from right part subarray divided by the maximum number.
    Construct the maximum tree by the given array and output the root node of this tree.

    Example 1:
    Input: [3,2,1,6,0,5]
    Output: return the tree root node representing the following tree:

          6
        /   \
       3     5
        \    / 
         2  0   
           \
            1
    Note:
    The size of the given array will be in the range [1,1000].
     * **/
    public class Maximum_Binary_Tree654
    {
        /// <summary>
        /// 思路  找到最大值对于位置 赋值给root,
        /// 左边重复上述  右边重复上述，返回值赋值给对于的root的左右子树
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            //获取root
            int maxnum = nums[0];
            int maxindex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxnum)
                {
                    maxnum = nums[i];
                    maxindex = i;
                }
            }
            ///区分最大值 左右数组
            int[] leftNums =  new int[maxindex];
            int[] rightNums = new int[nums.Length-1-maxindex];
            for (int i = 0; i < maxindex; i++)
            {
                leftNums[i] = nums[i];
            }
            for (int i = 0; i < nums.Length - 1 - maxindex; i++)
            {
                rightNums[i] = nums[i + maxindex+1];
            }
            TreeNode treeNode = new TreeNode(maxnum);
            if (leftNums.Length > 0)
            {
                treeNode.left = ConstructMaximumBinaryTree(leftNums); //左边数组递归，返回值赋值给左子树
            }
            if (rightNums.Length > 0)
            {
                treeNode.right = ConstructMaximumBinaryTree(rightNums);//右边数组递归，返回值赋值给右子树
            }
            return treeNode;
        }
    }
}
