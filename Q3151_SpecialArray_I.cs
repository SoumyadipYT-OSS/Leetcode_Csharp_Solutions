public class Solution {
    public bool IsArraySpecial(int[] nums) {
        for (int index = 0; index < nums.Length - 1; index++) {
            if (((nums[index] & 1) ^ (nums[index + 1] & 1)) == 0) {
                return false;
            }
        }

        return true;
    }
}
