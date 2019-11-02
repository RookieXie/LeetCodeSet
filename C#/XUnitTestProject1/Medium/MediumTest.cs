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
        [Fact]
        public void ScoreAfterFlippingMatrix861Test()
        {
            ScoreAfterFlippingMatrix861 scoreAfterFlippingMatrix = new ScoreAfterFlippingMatrix861();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int[][] nums = new int[][] { new int[] { 0, 0, 1, 1 },new int[] { 1, 0, 1, 0 }, new int[] { 1, 1, 0, 0 } };
            int output = scoreAfterFlippingMatrix.MatrixScore(nums);
            Assert.Equal(39,output);
        }
        [Fact]
        public void Maximum_Binary_Tree654Test()
        {
            Maximum_Binary_Tree654 maximum_Binary = new Maximum_Binary_Tree654();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int[]nums = new int[] { 3, 2, 1, 6, 0, 5 };
            TreeNode output = maximum_Binary.ConstructMaximumBinaryTree(nums);
            Assert.True(true);
        }
    }
}
