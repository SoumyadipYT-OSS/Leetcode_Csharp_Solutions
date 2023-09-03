public class Solution {
    public int UniquePaths(int m, int n) {
        int[,] dp = new int[m+1,n+1];
        dp[1,0]=1;
        for(int r=1;r<=m;r++){
            for(int c=1;c<=n;c++){
                dp[r,c]=dp[r-1,c]+dp[r,c-1];
            }
        }
        return dp[m,n];
    }
}