public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        
        void recursiveSubsets(List<int> input, IList<int> availableNums){
            result.Add(input);

            for (var i = 0; i < availableNums.Count; i++){
                var numsWithoutCurrent = availableNums.Skip(i + 1).ToList();

                var newInput = input.ToList();
                newInput.Add(availableNums[i]);

                recursiveSubsets(newInput, numsWithoutCurrent);
            }
        }

        recursiveSubsets(new List<int>(), nums);

        return result;
    }
}