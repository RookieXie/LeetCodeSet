using LeetCode.Tree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    public class BinaryTreeTest
    {
        [Fact]
        public void PreorderTraversalTest()
        {
            TreeNode treeNode = new TreeNode(1);
            treeNode.right = new TreeNode(2);
            treeNode.right.left = new TreeNode(3);
            var list=new BinaryTree().PreorderTraversal(treeNode);

        }
    }
}
