package com.leetcode.medium;

import com.leetcode.models.TreeNode;

import java.util.ArrayList;
import java.util.List;

/*Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.

        Note: A leaf is a node with no children.

        Example:

        Given the below binary tree and sum = 22,

        5
        / \
        4   8
        /   / \
        11  13  4
        /  \    / \
        7    2  5   1
        Return:

        [
        [5,4,11,2],
        [5,8,4,5]
        ]*/
public class PathSumII113 {
    //思路：1.迭代，List<Integet> 保存每一步的值 2. 判断是否累加到等于sum,是则将List 加入到全局list里面
    List<List<Integer>> lists = new ArrayList<List<Integer>>();

    public List<List<Integer>> pathSum(TreeNode root, int sum) {
        if (root == null) return lists;
        List<Integer> list = new ArrayList<Integer>();
        PathList(root, sum, list);
        return lists;
    }

    public void PathList(TreeNode root, int sum, List<Integer> _list) {
        if (root != null) {
            List<Integer> list = new ArrayList<Integer>(_list);//防止引用类型问题
            list.add(root.val);
            if (root.right == null && root.left == null && sum == root.val)
                lists.add(list);
            PathList(root.right, sum - root.val, list);
            PathList(root.left, sum - root.val, list);
        }
    }

}
