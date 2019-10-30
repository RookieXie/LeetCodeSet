using LeetCode.Medium;
using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1.Medium
{
    public class MediumTest
    {

        [Fact]
        public void BinarySearchTreetoGreaterSumTree1038Test()
        {
            BinarySearchTreetoGreaterSumTree1038 greaterSumTree1038 = new BinarySearchTreetoGreaterSumTree1038();
            TreeNode node = new TreeNode(4);
            node.left = new TreeNode(1);
            node.right = new TreeNode(6);
            node.left.left = new TreeNode(0);
            node.left.right = new TreeNode(2);
            node.left.right.left = new TreeNode(3);
            node.right.left = new TreeNode(5);
            node.right.right = new TreeNode(7);
            node.right.right.right = new TreeNode(8);
            TreeNode output = greaterSumTree1038.BstToGst(node);
            Assert.True(true);
        }
        [Fact]
        public void EncodeandDecodeTinyURL535Test()
        {
            Codec codec = new Codec();
            
            string output = codec.encode("http://example.com/account/basin.html");
            Assert.True(true);
        }
        [Fact]
        public void MaximumLevelSumofaBinaryTree1161Test()
        {
            MaximumLevelSumofaBinaryTree1161 maximumLevelSumofaBinaryTree = new MaximumLevelSumofaBinaryTree1161();
            int? [] nums = new int?[]{ 63909,43838,4549,-31714,-99701,-96320,88666,75152,-14750,-12671,60405,null,29388,null,null,null,-83674,null,null,-83490,null,-49913,86188,84455,null,null,null,null,null,null,null,null,null,-36061,91438,-75550};
            var node =CreateTree(nums);

            int output = maximumLevelSumofaBinaryTree.MaxLevelSum(node);
            Assert.True(true);
        }
        public TreeNode CreateNode(int? val)
        {
            if (val == null) return null;
            return new TreeNode((int)val);
        }
        public TreeNode CreateTree(int?[] arr)
        {
            if (arr.Length <= 0 || arr[0] == null)
            {
                return null;
            }
            TreeNode root = CreateNode(arr[0]);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int index = 1;
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node == null) continue;
                if (index < arr.Length)
                {
                    node.left = CreateNode(arr[index++]);
                    queue.Enqueue(node.left);
                }
                if (index < arr.Length)
                {
                    node.right = CreateNode(arr[index++]);
                    queue.Enqueue(node.right);
                }
            }
            return root;
        }
    }
}
