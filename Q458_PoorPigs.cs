using System;

public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        if(buckets<2){
            return 0;
        }
        int n=1;
        int c=1;
        int x=1+(minutesToTest/minutesToDie);
        while(x*n<buckets){
            n=x*n;
            c++;
        }
        return c;
    }
}