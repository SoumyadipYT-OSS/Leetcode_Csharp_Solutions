public class Solution {
    public int FindLongestChain(int[][] pairs) {
        Array.Sort(pairs, (a,b)=> {return a[1]-b[1];});

        int tail = int.MinValue, ans = 0;

        foreach(var pair in pairs)
        {
            if(pair[0]>tail)
            {
                ans++;
                tail = pair[1];
            }
        }

        return ans;
    }
}