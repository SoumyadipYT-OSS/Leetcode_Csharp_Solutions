/*
https://leetcode.com/problems/count-elements-with-maximum-frequency/solutions/4841348/100-beats-3005-count-elements-with-maximum-frequency/
*/


ans:

public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        var d = new Dictionary<int, int>();
        var maxFrequency = 0;
        var maxCount = 0;

        foreach (var n in nums) {
            if (d.ContainsKey(n)) {
                ++d[n];
            } else {
                d[n] = 1;
            }

            if (d[n] > maxFrequency) {
                maxFrequency = d[n];
                maxCount = 1;
            } else if (d[n] == maxFrequency) {
                maxCount++;
            }
        }

        return maxCount * maxFrequency;
    }
}