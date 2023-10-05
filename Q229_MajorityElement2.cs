public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int length = nums.Length;
        int[] candidates = new int[2];
        int[] counts = new int[2];

        FindCandidates(nums, candidates, counts);

        IList<int> result = new List<int>();
        if (counts[0] > length / 3){
            result.Add(candidates[0]);
        }
        if (counts[1] > length / 3){
            result.Add(candidates[1]);
        }

        return result;
    }

    private void FindCandidates(int[] nums, int[] candidates, int[] counts){
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == candidates[0]){
                counts[0]++;
            }
            else if (nums[i] == candidates[1]){
                counts[1]++;
            }
            else if (counts[0] == 0){
                candidates[0] = nums[i];
                counts[0] = 1;
            }
            else if (counts[1] == 0){
                candidates[1] = nums[i];
                counts[1] = 1;
            }
            else{
                counts[0]--;
                counts[1]--;
            }
        }
        CountCandidatesElement(nums, candidates, counts);
    }

    private void CountCandidatesElement(int[] nums, int[] candidates, int[] counts){
        counts[0] = 0;
        counts[1] = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == candidates[0]){
                counts[0]++;
            }
            else if (nums[i] == candidates[1]){
                counts[1]++;
            }
        }
    }
}
