/* Length of Longest Fibonacci Subsequence */


public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
         // Dictionary to store the indices of the elements
 var index = new Dictionary<int, int>();
 for (int i = 0; i < arr.Length; i++)
 {
     index[arr[i]] = i;
 }

 // Dictionary to store the length of the longest Fibonacci-like subsequence ending with (arr[i], arr[j])
 var longest = new Dictionary<(int, int), int>();
 int maxLen = 0;

 // Iterate over all pairs (arr[i], arr[j])
 for (int k = 0; k < arr.Length; k++)
 {
     for (int j = 0; j < k; j++)
     {
         int iValue = arr[k] - arr[j];
         if (iValue < arr[j] && index.ContainsKey(iValue))
         {
             int i = index[iValue];
             var len = longest.GetValueOrDefault((i, j), 2) + 1;
             longest[(j, k)] = len;
             maxLen = System.Math.Max(maxLen, len);
         }
     }
 }

 // If no Fibonacci-like subsequence found, return 0
 return maxLen >= 3 ? maxLen : 0;
    }
}
