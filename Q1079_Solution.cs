/* Letter Tile Possibilities */

public class Solution {
    private int count = 0;
    public int NumTilePossibilities(string tiles) {
        char[] charS = tiles.ToCharArray();
        Array.Sort(charS);
        Backtrack(0,charS);
        return count - 1;
    }

    public void Backtrack(int start,char[] nums)
    {
        // base condition
        count++;

        for (int i = start; i < nums.Length; i++)
        {   
            if (IsDuplicate(nums, start, i)) {
                continue;
            }
                Swap(ref nums[start], ref nums[i]);
                Backtrack(start + 1, nums);
                Swap(ref nums[start], ref nums[i]);
            
        }
        return;
    }

    private void Swap (ref char nums1, ref char nums2)
    {
        char temp = nums1;
        nums1 = nums2;
        nums2 = temp; 
    }

    private bool IsDuplicate(char[] nums, int start, int end) {
        for (int i = start; i < end; i++) {
            if (nums[i] == nums[end]) {
                return true;
            }
        }
        return false;
    }
}
