// Leetcode 1189.Maximum Number of balloons

public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> farr = new Dictionary<char, int>();
        foreach (char c in text) {
            if (farr.ContainsKey(c)) {
                farr[c]++;
            } else {
                farr[c] = 1;
            }
        }
        string s = "balloon";
        int res = 0;
        foreach (char i in s) {
            if (!farr.ContainsKey(i)) {
                return res;  
            }
        }
        while (true) {
            if (farr.ContainsKey('b') && farr['b'] >= 1 &&
                farr.ContainsKey('a') && farr['a'] >= 1 &&
                farr.ContainsKey('l') && farr['l'] >= 2 &&
                farr.ContainsKey('o') && farr['o'] >= 2 &&
                farr.ContainsKey('n') && farr['n'] >= 1) {
                
                res++;

                farr['b']--;
                farr['a']--;
                farr['l'] -= 2;
                farr['o'] -= 2;
                farr['n']--;
            } else {
                break;
            }
        }
        return res;
    }
}