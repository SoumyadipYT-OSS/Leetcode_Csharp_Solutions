public class Solution {
    public int LongestStrChain(string[] words) {
        int[] dp = new int[words.Length];
        Array.Sort(words, (w1, w2) => w1.Length - w2.Length);

        for(int i=words.Length-1; i>=0; i--){
            dp[i] = 1;
            int nextLen = words[i].Length+1;

            for(int j=i+1; j < words.Length && words[j].Length <= nextLen; j++){
                if(words[i].Length == words[j].Length){
                    continue;
                }

                if(IsPredecessor(words[i], words[j])){
                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
                }
            }
        }

        int res = 0;

        for(int i=0; i<words.Length; i++){
            res = Math.Max(res, dp[i]);
        }

        return res;
    }

    private bool IsPredecessor(string word1, string word2){
        int i=0, j=0, count = 1;

        while(i < word1.Length && j < word2.Length){
            if(word1[i] == word2[j]){
                i++;
                j++;
                continue;
            }
            else if(count == 0){
                return false;
            }
            else{
                count--;
                j++;
            }
        }

        return true;
    }
}