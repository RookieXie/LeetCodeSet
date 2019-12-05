package com.leetcode.easy;

import java.util.ArrayList;
import java.util.HashSet;

/*
* Given two arrays, write a function to compute their intersection.

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Note:

Each element in the result must be unique.
The result can be in any order.
 */
public class Intersection_of_Two_Arrays349 {
    /**/
    public int[] intersection(int[] nums1, int[] nums2) {
        HashSet<Integer> hs = new HashSet<Integer>();
        HashSet<Integer> rhs = new HashSet<Integer>();
        for (int i = 0; i < nums1.length; i++) {
            hs.add(nums1[i]);
        }
        for (int i = 0; i < nums2.length; i++) {
            if (hs.contains(nums2[i])) {
                rhs.add(nums2[i]);
            }
        }
        int[] list = new int[rhs.size()];
        int i = 0;
        for (Integer v : rhs) {
            list[i] = v;
            i++;
        }
        return list;
    }
}
