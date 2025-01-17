using System.Linq;
public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        return (nums1.Length % 2) * nums2.Aggregate(0, (acc, x) => acc ^ x) ^ (nums2.Length % 2) * nums1.Aggregate(0, (acc, x) => acc ^ x);
    }
}
