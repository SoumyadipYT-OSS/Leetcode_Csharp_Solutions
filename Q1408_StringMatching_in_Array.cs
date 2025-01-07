using System;
using System.Collections.Generic;

public class Solution {
    public IList<string> StringMatching(string[] words) {
        List<string> str = new List<string>();
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words.Length; j++) {
                if (i != j) {
                    if (words[j].Contains(words[i])) {
                        str.Add(words[i]);
                        break;
                    }
                }
            }
        }
        return str;
    }
}
