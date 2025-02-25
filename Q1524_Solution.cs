/* Number of Sub-arrays With Odd Sum */


public class Solution {
    public int NumOfSubarrays(int[] arr) {
        long OddCount = 0, PrefixSum = 0;
        foreach (int i in arr) {
            PrefixSum += i;
            OddCount += PrefixSum % 2;
        }

        OddCount += (arr.Length - OddCount) * OddCount;

        return (int)(OddCount % 1_000_000_007);
    }
}
