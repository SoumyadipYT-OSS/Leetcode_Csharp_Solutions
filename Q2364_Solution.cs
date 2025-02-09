/* Count Number of Bad Pairs */

public class Solution {
    public long CountBadPairs(int[] nums) {
     long cnt=0;
     int n= nums.Length;
     Dictionary<int,int> mp= new Dictionary<int,int>();
     for(int i=0;i<n;i++){
        int prev=0;
        if(!mp.ContainsKey(i-nums[i]))prev=0;
        else prev=mp[i-nums[i]];
        cnt+= prev;
        mp[i-nums[i]]=prev+1;
    }
    return 1L*n*(n-1)/2-cnt;   
    }
}
