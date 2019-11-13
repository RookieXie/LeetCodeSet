package com.leetcode.easy;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;
/*
Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.

Note that the row index starts from 0.


In Pascal's triangle, each number is the sum of the two numbers directly above it.

Example:

Input: 3
Output: [1,3,3,1]
Follow up:

Could you optimize your algorithm to use only O(k) extra space?
* */
public class PascalsTriangleII119 {
    public List<Integer> getRow(int rowIndex) {
        List<Integer> prelist = new ArrayList<Integer>();
        for (int i = 0; i < rowIndex; i++) {
            List<Integer> list = new ArrayList<Integer>();
            if(i<2){
                for (int j = 0; j <=i ; j++) {
                    list.add(1);
                }
            }else{
                list.add(1);
                for (int j = 1; j < i; j++) {
                    list.add(prelist.get(j-1)+prelist.get(j));
                }
                list.add(1);
            }
            prelist=list;
        }
        return prelist;
    }
}
