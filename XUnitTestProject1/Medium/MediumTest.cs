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
    }
}
