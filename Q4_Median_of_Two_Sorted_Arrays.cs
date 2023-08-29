public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double median = 0;
        int i1 = 0;
        int i2 = 0;
        int nal = nums1.Length + nums2.Length;
        int[] numsAll = new int[nal];

        while (i1 + i2 < numsAll.Length)
        {
            if (i2 == nums2.Length || i1 < nums1.Length && nums1[i1] <= nums2[i2])
            {
                numsAll[i1 + i2] = nums1[i1];
                i1++;
            }
            else
            {
                numsAll[i1 + i2] = nums2[i2];
                i2++;
            }
        }

        if (nal % 2 == 0)
        {
            median = (double)((numsAll[nal / 2 - 1] + numsAll[nal / 2])) / 2;
        }
        else
        {
            median = numsAll[nal / 2];
        }
        
        return median;
    }
}