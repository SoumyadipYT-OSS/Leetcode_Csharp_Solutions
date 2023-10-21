public class Solution {
    public int ConstrainedSubsetSum(int[] nums, int k) {

        var pq = new PriorityQueue<(int sum,int index), int>();
        pq.Enqueue((nums[0], 0), -nums[0]); 
        int ans = nums[0]; 
        
        for(int i=1; i<nums.Length; i++) {            
            int left = i - k - 1;  

            while(pq.Count > 0 && left >= pq.Peek().index){
                pq.Dequeue();
            }
            
            int first = pq.Count > 0 ? pq.Peek().sum : 0; 
            int curMax = Math.Max(0, first) + nums[i]; 
            ans = Math.Max(ans, curMax);
            pq.Enqueue((curMax, i), -curMax);
        }
        
        return ans;
    }
}
