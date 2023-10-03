public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        // two for loops
        int counter = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j] && i < j)
                {
                    counter++;
                }
            }
        }
        return counter;
    }
}