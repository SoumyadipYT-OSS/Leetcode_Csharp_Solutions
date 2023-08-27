public class Solution {
    public List<IList<string>> result = new List<IList<string>>();
    public IList<IList<string>> SolveNQueens(int n) {
        PutQueen(new List<int>(),n);
        return result;
    }

    public void PutQueen(List<int> l,int n){
        for(int i=0;i<l.Count-1;i++){
            if(Math.Abs(l[i] - l[l.Count-1]) == Math.Abs(l.Count - 1 -i)) return;
        }
        if(l.Count == n){
            result.Add(Generate(l));
            return;
        }
        for(int i=0;i<n;i++){
            if(!l.Contains(i)){
                l.Add(i);
                PutQueen(l,n);
                l.RemoveAt(l.Count-1);
            }
        }
    }


    public List<string> Generate(List<int> l) {
        List<string> temp = new List<string>();
        for(int j=0;j<l.Count;j++) {
            string line = "";
            for(int k=0;k<l.Count;k++){
                if(l[j] == k) line += "Q";
                else line += ".";
            }
            temp.Add(line);
        }
        return temp;
    }
}