/*
https://leetcode.com/problems/greatest-common-divisor-of-strings/solutions/4831224/100-beats-solution-problem1071/

visit this site for more step by step guidance
*/


public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        
        if (!(str1 + str2).Equals(str2 + str1)) return "";
        int gcdLength = gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);
    }

    public static int gcd(int x, int y) {
        if (y == 0) return x;
        else 
            return gcd(y, x % y);
    }
}