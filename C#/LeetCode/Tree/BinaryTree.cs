using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tree
{
    public class BinaryTree
    {
        /// <summary>
        /// 递归处理
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root != null)
            {
                list.Add(root.val);
                if (root.left != null)
                {
                    list.AddRange(PreorderTraversal(root.left));
                }
                if (root.right != null)
                {
                    list.AddRange(PreorderTraversal(root.right));
                }
            }
            
            return list;
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root != null)
            {
                if (root.left != null)
                {
                    list.AddRange(InorderTraversal(root.left));
                }
                list.Add(root.val);
                if (root.right != null)
                {
                    list.AddRange(InorderTraversal(root.right));
                }
            }

            return list;
        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root != null)
            {
                if (root.left != null)
                {
                    list.AddRange(PostorderTraversal(root.left));
                }
                
                if (root.right != null)
                {
                    list.AddRange(PostorderTraversal(root.right));
                }
                list.Add(root.val);
            }
            return list;
        }
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> list = new List<IList<int>>();
            //List<TreeNode> nodes = new List<TreeNode>();
            //if (root != null)
            //{
            //    nodes.Add(root);
            //}
            return list;
        }
    }
    
}
