public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int i = 0, j = nums.Length - 1;

        while (i < j) {
            while (i < j  &&  nums[i] % 2 == 0) 
            i++;
        
            while (i < j  &&  nums[j] % 2 == 1)
                j--;
        

            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        return nums;
    }
}