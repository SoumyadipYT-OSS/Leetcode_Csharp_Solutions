public class Solution {
    public int MaximumScore(int[] nums, int k) {
        int n = nums.Length;
        int l = k;
        int r = k;
        int lastMin = nums[k];
        int maxScore = nums[k];

        while (l != 0 || r + 1 != n)
        {
            if (l > 0 && r + 1 < n) {
                if (nums[l - 1] > nums[r + 1]) {
                    l--;
                } else {
                    r++;
                }
            }
            else if (l > 0) {
                l--;
            }
            else if (r + 1 < n) {
                r++;
            }

            lastMin = Math.Min(Math.Min(lastMin, nums[l]), nums[r]);
            maxScore = Math.Max(maxScore, lastMin * (r - l + 1));
        }

        return maxScore;
    }
}
