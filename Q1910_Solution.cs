/* Remove All Occurrences of a Substring */

public class Solution {
    public string RemoveOccurrences(string s, string part) {
        StringBuilder sb = new StringBuilder(s);
        int partLen = part.Length;

        int index = sb.ToString().IndexOf(part);
        while (index != -1) {
            sb.Remove(index, partLen);
            index = sb.ToString().IndexOf(part);
        }

        return sb.ToString();
    }
}
