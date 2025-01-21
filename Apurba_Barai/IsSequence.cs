// Leetcode 392.Is Subsequence

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int c = 0;
        int j = 0;
        foreach (char i in s) {
            while (j < t.Length) {
                if (t[j] == i) {
                    j++;
                    c++;
                    break;
                } else {
                    j++;
                }
            }
        }
        return c == s.Length;
    }
}
