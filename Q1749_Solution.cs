/* Maximum Absolute Sum of Any Subarray */

public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int MaxSum = 0, MinSum = 0, Max_EndingHere = 0, Min_EndingHere = 0;

        foreach (int i in nums) {
            Max_EndingHere += i;
            Min_EndingHere += i;

            MaxSum = Math.Max(MaxSum, Max_EndingHere);
            MinSum = Math.Min(MinSum, Min_EndingHere);

            if (Max_EndingHere < 0) Max_EndingHere = 0;
            if (Min_EndingHere > 0) Min_EndingHere = 0;
        }

        return Math.Max(MaxSum, Math.Abs(MinSum));
    }
}
