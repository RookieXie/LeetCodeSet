using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Given the root of a binary tree, the level of its root is 1, the level of its children is 2, and so on.

        Return the smallest level X such that the sum of all the values of nodes at level X is maximal.

 

        Example 1:



        Input: [1,7,0,7,-8,null,null]
        Output: 2
        Explanation: 
        Level 1 sum = 1.
        Level 2 sum = 7 + 0 = 7.
        Level 3 sum = 7 + -8 = -1.
        So we return the level with the maximum sum which is level 2.
     * **/
    public class MaximumLevelSumofaBinaryTree1161
    {
    
        /// <summary>
        /// 思路： 每一层相加，从根节点下去，一个递归就是一层 所以level+1,保证同层相加 使用数组或者dictionary
        /// </summary>
        Dictionary<int, int> dic = new Dictionary<int, int>();
        public int MaxLevelSum(TreeNode root)
        {
            int maxLevel = 1;
            int maxNum = Int32.MinValue;
            AddLevelNum(root, 1);
            foreach (var item in dic)
            {
                if (item.Value > maxNum)
                {
                    maxNum = item.Value;
                    maxLevel = item.Key;
                }
            }
            return maxLevel;
        }
        public void AddLevelNum(TreeNode treeNode, int level)
        {
            if (dic.ContainsKey(level))
            {
                dic[level] += treeNode.val;
            }
            else
            {
                dic.Add(level, treeNode.val);
            }
            
            if (treeNode.right != null) AddLevelNum(treeNode.right, level + 1);
            if (treeNode.left != null) AddLevelNum(treeNode.left, level + 1);
        }
    }
}
