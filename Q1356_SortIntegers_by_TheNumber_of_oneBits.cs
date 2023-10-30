public class Solution {

    public int[] SortByBits(int[] arr) {

        Array.Sort(arr);

        int cnt, target;

        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

        for (int i = 0; i < arr.Length; i ++) {

            cnt = 0; target = arr[i];

            while (target != 0) {

                if (target % 2 == 1) cnt ++;

                target /= 2;

            }

            if (dic.ContainsKey(cnt)) dic[cnt].Add(arr[i]);
            
            else dic.Add(cnt, new List<int>(new int[]{arr[i]}));

        }

        int idx = 0;

        int[] rslt = new int[arr.Length];

        cnt = -1;

        while (true) {

            cnt ++;

            if (!dic.ContainsKey(cnt)) continue;
            
            for (int i = 0; i < dic[cnt].Count; i ++) {
                
                rslt[idx] = dic[cnt][i];
                idx ++;

            }

            if (idx == arr.Length) break;

        }
        
        return rslt;
        
    }

}