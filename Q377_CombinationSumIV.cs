public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        
        int[] dp = new int[target + 1];
        dp[0] = 1;

        for(int i = 1; i < dp.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(i - nums[j] >= 0)
                {
                    dp[i] += dp[i - nums[j]];
                }
            }
        }
        
        return dp[target];
    }
}