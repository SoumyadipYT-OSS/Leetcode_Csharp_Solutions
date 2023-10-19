public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var sStack = new Stack<char>();
        var tStack = new Stack<char>();

        foreach(char c in s) {
          if(c != '#') {
            sStack.Push(c);
          } else if(sStack.Count > 0){
            sStack.Pop();
          }
        }

        foreach(char c in t) {
          if(c != '#') {
            tStack.Push(c);
          } else if(tStack.Count > 0){
            tStack.Pop();
          }
        }

        var sResult = sStack.Count > 0 ? new string(sStack.ToArray()) : "";
        var tResult = tStack.Count > 0 ? new string(tStack.ToArray()) : "";
        
        return  sResult == tResult;

    }
}