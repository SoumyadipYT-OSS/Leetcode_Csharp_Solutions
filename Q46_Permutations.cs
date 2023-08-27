public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
     List<IList<int>> result = new ();
        if ( nums == null || nums.Length == 0){
            return result;
        }
        Helper(nums, 0, result);
        return result;    
    }

    private void Helper(int[] nums, int index , List<IList<int>> result){
        if ( index == nums.Length){
            result.Add(new List<int>(nums));
            return;
        }
        for(int i = index; i < nums.Length; i++){
            Swap(nums, i, index);
            Helper(nums, index+1, result);
            Swap(nums,i, index);
        }
    }

    private void Swap(int[] nums, int a, int b){
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}