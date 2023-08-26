public class Solution {

    IList<string> a = new List<string>();
    int length;

    //Recursion solution
    public IList<string> GenerateParenthesis(int n) {
        length = n;
        GenerateParenthesis(0, 0, "");  // Initialize variables
        return a;    
    }

    
    public void GenerateParenthesis(int open, int close, string s) {
        if(open == close && open == length) {
            a.Add(s);  
            return;     
        }
        if(open < length) {
            GenerateParenthesis(open + 1, close, s + "(");
        }
        if (close < open) {
            GenerateParenthesis(open, close + 1, s + ")");
        }
    }
}