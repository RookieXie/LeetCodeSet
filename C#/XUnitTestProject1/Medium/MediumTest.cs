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
            int?[] nums = new int?[] { 63909, 43838, 4549, -31714, -99701, -96320, 88666, 75152, -14750, -12671, 60405, null, 29388, null, null, null, -83674, null, null, -83490, null, -49913, 86188, 84455, null, null, null, null, null, null, null, null, null, -36061, 91438, -75550 };
            var node = CreateTree(nums);

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
            int[][] nums = new int[][] { new int[] { 0, 0, 1, 1 }, new int[] { 1, 0, 1, 0 }, new int[] { 1, 1, 0, 0 } };
            int output = scoreAfterFlippingMatrix.MatrixScore(nums);
            Assert.Equal(39, output);
        }
        [Fact]
        public void Maximum_Binary_Tree654Test()
        {
            Maximum_Binary_Tree654 maximum_Binary = new Maximum_Binary_Tree654();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int[] nums = new int[] { 3, 2, 1, 6, 0, 5 };
            TreeNode output = maximum_Binary.ConstructMaximumBinaryTree(nums);
            Assert.True(true);
        }

        [Fact]
        public void Letter_Tile_Possibilities1079Test()
        {
            Letter_Tile_Possibilities1079 tile_Possibilities1079 = new Letter_Tile_Possibilities1079();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            string input = "AAB";
            int output = tile_Possibilities1079.NumTilePossibilities2(input);
            Assert.Equal(8, output);
        }
        [Fact]
        public void Construct_Binary_Search_Tree_from_Preorder_Traversal1008Test()
        {
            Construct_Binary_Search_Tree_from_Preorder_Traversal1008 construct_Binary_Search_Tree_From_Preorder = new Construct_Binary_Search_Tree_from_Preorder_Traversal1008();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int[] input = new int[] { 8, 5, 1, 7, 10, 12 };
            TreeNode output = construct_Binary_Search_Tree_From_Preorder.BstFromPreorder(input);
            Assert.True(output.val == 8);
        }
        [Fact]
        public void Search_in_Rotated_Sorted_Array33Test()
        {
            Search_in_Rotated_Sorted_Array33 search_In_Rotated_Sorted_ = new Search_in_Rotated_Sorted_Array33();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int[] input = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int output = search_In_Rotated_Sorted_.Search(input, 3);
            Assert.Equal(-1, output);
        }
        [Fact]
        public void Validate_Binary_Search_Tree98Test()
        {
            Validate_Binary_Search_Tree98 validate_Binary_Search = new Validate_Binary_Search_Tree98();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int?[] input = new int?[] { 0 };
            var node = CreateTree(input);
            bool output = validate_Binary_Search.IsValidBST(node);
            Assert.True(output);
        }
        [Fact]
        public void VGroup_Anagrams49Test()
        {
            Group_Anagrams49 group_Anagrams49 = new Group_Anagrams49();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            string[] input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var output = group_Anagrams49.GroupAnagrams(input);
            Assert.True(true);
        }
        [Fact]
        public void Fraction_to_Recurring_Decimal166Test()
        {
            Fraction_to_Recurring_Decimal166 recurring_Decimal166 = new Fraction_to_Recurring_Decimal166();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int input1 = -1;

            int input2 = 333;
            var output = recurring_Decimal166.FractionToDecimal(input1, input2);
            Assert.Equal("0.5", output);
        }
        [Fact]
        public void Repeated_DNA_Sequences187Test()
        {
            Repeated_DNA_Sequences187 sequences187 = new Repeated_DNA_Sequences187();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            string input = "GAGAGAGAGAGAG";
            var output = sequences187.FindRepeatedDnaSequences(input);
            Assert.True(true);
        }
        [Fact]
        public void H_Index274Test()
        {
            H_Index274 h_Index274 = new H_Index274();
            //[0,0,1,1],[1,0,1,0],[1,1,0,0]
            int[] input = new int[] { 3, 0, 6, 1, 5 };
            var output = h_Index274.HIndex(input);
            Assert.True(true);
        }
        

    }
}
