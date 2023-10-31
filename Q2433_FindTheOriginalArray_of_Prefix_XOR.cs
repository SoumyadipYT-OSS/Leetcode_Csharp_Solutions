public class Solution {
    public int[] FindArray(int[] pref) {
        int[] output = new int[pref.Length];
        int currentNum = 0;
        for (int i = 0; i < pref.Length; i++) {
            if (i == 0) {
                output[i] = pref[i];
            } else {
                currentNum = pref[i-1] ^ pref[i];
                output[i] = currentNum;
            }
        }
        
        return output;
    }
}