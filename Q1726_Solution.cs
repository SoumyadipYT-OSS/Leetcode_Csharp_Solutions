/* Tuple with Same Product */

public class Solution {
    public int TupleSameProduct(int[] nums) {
        int R = 0;
        Dictionary<int, int> D = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length - 1; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                int key = nums[i] * nums[j];
                if (!D.ContainsKey(key)) {
                    D[key] = 0;
                }
                D[key]++;
                R += D[key] - 1;
            }
        }
        return R * 8;
    }
}
