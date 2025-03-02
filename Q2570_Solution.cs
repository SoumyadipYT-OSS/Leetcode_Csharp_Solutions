/* Merge Two 2D Arrays by Summing Values */

public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        Dictionary<int, int> valueMap = new Dictionary<int, int>();

        // adding values from `nums1` to dictionary
        foreach (var pair in nums1) {
            int id = pair[0];
            int value = pair[1];
            valueMap[id] = value;
        }

        // adding values from `nums2` to dictionary
        foreach (var pair in nums2) {
            int id = pair[0];
            int value = pair[1];
            if (valueMap.ContainsKey(id)) {
                valueMap[id] += value;
            } else {
                valueMap[id] = value;
            }
        }


        // convert the dictionary to a sorted list of arrays
        List<int[]> result = new List<int[]>();
        foreach (var kvp in valueMap) {
            result.Add(new int[] {kvp.Key, kvp.Value});
        }

        result.Sort((a, b) => a[0].CompareTo(b[0]));

        return result.ToArray();
    }
}
