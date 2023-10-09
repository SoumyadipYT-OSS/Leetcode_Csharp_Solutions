public class Solution {
    public int[] SearchRange(int[] nums, int target) {
         int l = 0, r=nums.Length-1;
            while (l <=r)
            {
                if (nums[r] == target && nums[l] == target)
                    return new int[] { l, r };
                if (nums[l] < target)
                    l++;
                if (nums[r] > target)
                    r--;
            }
            return new int[] { -1,-1 };  
    }
}
