/* Partition Array According to Given Plot */

public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int n = nums.Length;
        int[] res = new int[n];

        int less = 0, equal = 0, greater = n - 1;

        foreach (int i in nums) {
            if (i < pivot)
                res[less++] = i;
            else if (i ==  pivot)
                equal++;
        }

        int curr = less;
        for (int i = 0; i < equal; i++)
            res[curr++] = pivot;
        
        foreach (int i in nums) {
            if (i > pivot)
                res[curr++] = i;
        }

        return res;
    }
}
