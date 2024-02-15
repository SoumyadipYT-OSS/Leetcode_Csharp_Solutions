/*2971. Find Polygon With the Largest Perimeter

Question: You are given an array of positive integers nums of length n.

A polygon is a closed plane figure that has at least 3 sides. The longest side of a polygon is smaller than the sum of its other sides.

Conversely, if you have k (k >= 3) positive real numbers a1, a2, a3, ..., ak where a1 <= a2 <= a3 <= ... <= ak and a1 + a2 + a3 + ... + ak-1 > ak, 
then there always exists a polygon with k sides whose lengths are a1, a2, a3, ..., ak.

The perimeter of a polygon is the sum of lengths of its sides.

Return the largest possible perimeter of a polygon whose sides can be formed from nums, or -1 if it is not possible to create a polygon.

 

Example 1:
Input: nums = [5,5,5]
Output: 15
Explanation: The only possible polygon that can be made from nums has 3 sides: 5, 5, and 5. The perimeter is 5 + 5 + 5 = 15.

Example 2:
Input: nums = [1,12,1,2,5,50,3]
Output: 12
Explanation: The polygon with the largest perimeter which can be made from nums has 5 sides: 1, 1, 2, 3, and 5. The perimeter is 1 + 1 + 2 + 3 + 5 = 12.






ans:
*/

public class Solution {
    public long LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        var prefix = new long[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            prefix[i] = i == 0 ? nums[i] : nums[i] + prefix[i - 1];
        for (int i = nums.Length - 1; i >= 2; i--) {
            if (nums[i] >= prefix[i - 1]) continue;
            return prefix[i];
        }

        return -1;
    }
}