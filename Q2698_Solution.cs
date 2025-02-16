/* Find the Punishment Number of an Integer */


public class Solution {
    public int PunishmentNumber(int n) { // 4ms
        int result=1;
        for(int i=9; i<=n; i++) {
            int p=i*i;
            for(int d1=10; d1<p; d1*=10) { // split number by division
                int q1=Math.DivRem(p, d1, out int r1);
                int m1=i-r1; // optimization: now we should try to match i-r1
                if(m1<0) break; // optimization: if that's negative, we're done
                if(m1==q1) { result+=p; break; }
                for(int d2=10; d2<q1; d2*=10) { // split quotient 1 from above
                    int q2=Math.DivRem(q1, d2, out int r2);
                    int m2=m1-r2; // optimization: try to match m1-r2
                    if(m2==q2) { result+=p; goto nextI; }
                    for(int d3=10; d3<q2; d3*=10) { // split quotient 2 from above
                        int q3=Math.DivRem(q2, d3, out int r3);
                        if(m2==q3+r3) { result+=p; goto nextI; }
                    }
                }
            }
        nextI: ;
        }
        return result;
    }
}
