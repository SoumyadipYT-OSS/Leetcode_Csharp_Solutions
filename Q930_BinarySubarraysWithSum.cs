/*
Given a binary array nums and an integer goal, return the number of non-empty subarrays with a sum goal.

A subarray is a contiguous part of the array.

 

Example 1:

Input: nums = [1,0,1,0,1], goal = 2
Output: 4
Explanation: The 4 subarrays are bolded and underlined below:
[1,0,1,0,1]
[1,0,1,0,1]
[1,0,1,0,1]
[1,0,1,0,1]
*/


 // ans:

public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int l = nums.Length;
        if (l == 1)
            return nums[0] == goal ? 1 : 0;
        
        int[] arrSum = new int[l + 1];
        int sum = 0;
        int count = 0;
        for (int i=0; i<l; i++) {
            sum += nums[i];
            if (sum == goal)
                count++;
            
            if (sum >= goal)
                count += arrSum[sum - goal];
            
            arrSum[sum]++;
        }
        return count;
    }
}
