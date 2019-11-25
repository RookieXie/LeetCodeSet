package com.leetcode.medium;

import java.lang.reflect.Array;
import java.util.*;

/*
* Given a non-empty array of integers, return the k most frequent elements.

    Example 1:

    Input: nums = [1,1,1,2,2,3], k = 2
    Output: [1,2]
    Example 2:

    Input: nums = [1], k = 1
    Output: [1]
    Note:

    You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
    Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
* */
public class Top_K_Frequent_Elements347 {
    //1.思路 用HashMap 存储数字和对应的次数
    // 然后循环 找出最大值，获取到 然后删除，重复k次
    public List<Integer> topKFrequent(int[] nums, int k) {
        List<Integer> list = new ArrayList<Integer>();
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        List<Integer> _list = new ArrayList<Integer>();
        for (int i = 0; i < nums.length; i++) {
            if (map.containsKey(nums[i])) {
                int t = map.get(nums[i]) + 1;
                map.put(nums[i], t);
            } else {
                map.put(nums[i], 1);
                _list.add(nums[i]);
            }
        }
        for (int i = 0; i < k; i++) {
            int max = 0;
            int length = _list.size();
            int key = 0;
            for (int j = 0; j < length; j++) {
                if (map.get(_list.get(j)) >= max) {
                    max = map.get(_list.get(j));
                    key = j;
                }
            }
            list.add(_list.get(key));
            _list.remove(key);

        }

        return list;
    }

    /*
    2.优化：减少数组的操作，使用HashMap的遍历
    */
    public List<Integer> topKFrequent2(int[] nums, int k) {
        List<Integer> list = new ArrayList<Integer>();
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        for (int i = 0; i < nums.length; i++) {
            if (map.containsKey(nums[i])) {
                int t = map.get(nums[i]) + 1;
                map.put(nums[i], t);
            } else {
                map.put(nums[i], 1);
            }
        }
        for (int i = 0; i < k; i++) {
            int max = 0;
            int key = 0;
            for (Map.Entry<Integer, Integer> entry : map.entrySet()) {
                if (entry.getValue() >= max) {
                    max = entry.getValue();
                    key = entry.getKey();
                }
            }
            list.add(key);
            map.remove(key);
        }
        return list;
    }
}
