public class Solution {
    public int BestClosingTime(string customers) {
        int penalty = 0;
        for (int i = 0; i < customers.Length; i++) {
            if (customers[i] == 'N') penalty++;
        }
        
        int min = penalty;
        int min_index = customers.Length;
        for (int i = customers.Length; i > 0; i--) {
            if (customers[i-1] == 'Y') penalty++;
            else penalty--;
            if (min >= penalty) {
                min = penalty;
                min_index = i-1;
            }
        }
        return min_index;
    }
}