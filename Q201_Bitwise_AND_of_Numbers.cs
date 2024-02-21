public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        int offset = 0;
        while (left != right) {
            left >>= 1;
            right >>= 1;
            offset++;
        }
        
        return left << offset;
    }
}