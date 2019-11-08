
package LeetCore.Kotlin
/*Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai).
 n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
 Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container and n is at least 2.

 



The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

 

Example:

Input: [1,8,6,2,5,4,8,3,7]
Output: 49 */
//思路：1 从两边开始  按小的作为宽*（两边之差为长）算面积，与最大值比较再取最大值  2 哪边大 +1  重复1步骤，
fun maxArea(height: IntArray): Int {
    var left=0
    var right=height.size-1
    var maxValue=0
    while(right>left){
        var temp=0
        if(height[right]>height[left]){
            temp=height[left]*(right-left)            
            left++
        }else{
            temp=height[right]*(right-left)
            right--
        }
        if(temp>maxValue){
            maxValue=temp
        }
    }
    return maxValue
} 