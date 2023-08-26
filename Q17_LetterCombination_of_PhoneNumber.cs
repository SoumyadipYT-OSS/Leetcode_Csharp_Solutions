using System.Collections.Generic;

public class Solution {
    private static readonly string[] letters = new string[]
    {
        "",     // 0
        "",     // 1
        "abc",  // 2
        "def",  // 3
        "ghi",  // 4
        "jkl",  // 5
        "mno",  // 6
        "pqrs", // 7
        "tuv",  // 8
        "wxyz"  // 9
    };
    
    public IList<string> LetterCombinations(string digits) {
        IList<string> result = new List<string>();
        if (string.IsNullOrEmpty(digits)) return result;

        Backtrack(digits, 0, "", result);
        return result;
    }

    private void Backtrack(string digits, int index, string current, IList<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(current);
            return;
        }

        char digit = digits[index];
        string mappedLetters = letters[digit - '0'];

        for (int i = 0; i < mappedLetters.Length; i++)
        {
            Backtrack(digits, index + 1, current + mappedLetters[i], result);
        }
    }
}