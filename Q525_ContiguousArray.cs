/*
Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.

 

Example 1:

Input: nums = [0,1]
Output: 2
Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
Example 2:

Input: nums = [0,1,0]
Output: 2
Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
*/

public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int count = 0;
        int ans = 0;
        map[0] = -1;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                count++;
            } else {
                count--;
            }

            if (map.ContainsKey(count)) {
                ans = Math.Max(ans, i - map[count]);
            } else {
                map[count] = i;
            }
        }
        return ans;
    }
}