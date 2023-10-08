public class Solution {
    public int MaxDotProduct(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int m = nums2.Length;
        int[,] memo = new int[n, m];
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                memo[i, j] = int.MinValue;
            }
        }
        
        return DP(nums1, nums2, 0, 0, memo);
    }
    
    private int DP(int[] nums1, int[] nums2, int i, int j, int[,] memo) {
        int n = nums1.Length;
        int m = nums2.Length;
        
        if (i == n || j == m) {
            return int.MinValue;
        }
        
        if (memo[i, j] != int.MinValue) {
            return memo[i, j];
        }
        
        memo[i, j] = Math.Max(
            nums1[i] * nums2[j] + Math.Max(DP(nums1, nums2, i + 1, j + 1, memo), 0),
            Math.Max(DP(nums1, nums2, i + 1, j, memo), DP(nums1, nums2, i, j + 1, memo))
        );
        
        return memo[i, j];
    }
}
