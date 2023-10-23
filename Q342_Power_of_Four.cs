public class Solution {
    public bool IsPowerOfFour(int n) {
        if(n<=0) return false;
        if(n==1) return true;
        while(n%4==0)
        {
            n/=4;
        }
        if(n==1) return true;
        return false;
    }
}