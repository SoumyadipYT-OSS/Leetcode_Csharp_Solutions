public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        double[] cur = new double[]{poured};
        while(query_row-- > 0){
            double[] tmp = new double[cur.Length + 1];
            tmp[0] = tmp[tmp.Length - 1] = Math.Max((cur[0] - 1) / 2,0);
            for(int i = 1;i < tmp.Length - 1;i++){
                tmp[i] = Math.Max((cur[i - 1] - 1) / 2,0) + Math.Max((cur[i] - 1) / 2,0);
            }
            cur = tmp;
        }
        return Math.Min(1,cur[query_glass]);
    }
}