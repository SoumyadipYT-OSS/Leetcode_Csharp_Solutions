public class Solution {
    public int MinTaps(int n, int[] ranges) {
        int[] arr = new int[n + 1];
        Array.Fill(arr, 0);
        
        for(int i = 0; i < ranges.Length; i++) {
            if(ranges[i] == 0) continue;
            int left = Math.Max(0, i - ranges[i]);
            arr[left] = Math.Max(arr[left], i + ranges[i]);
        }
        
        int end = 0, far_can_reach = 0, cnt = 0;
        for(int i = 0; i <= n; i++) {
            if(i > end) {
                if(far_can_reach <= end) return -1;
                end = far_can_reach;
                cnt++;
            }
            far_can_reach = Math.Max(far_can_reach, arr[i]);
        }
        
        return cnt + (end < n ? 1 : 0);
    }
}