// Leetcode 13.Roman to integer

public class Solution {
    public int RomanToInt(string s) {
        int num = 0;
        Dictionary<string, int> m = new Dictionary<string, int> {
            { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 },
            { "D", 500 }, { "M", 1000 }, { "IV", 4 }, { "IX", 9 }, { "XL", 40 },
            { "XC", 90 }, { "CD", 400 }, { "CM", 900 }
        };
        int i = 0;
        while (i < s.Length) {
            if (i + 1 < s.Length && m.ContainsKey(s.Substring(i, 2))) {
                num += m[s.Substring(i, 2)];
                i += 2;
            } else {
                num += m[s.Substring(i, 1)];
                i += 1;
            }
        }
        return num;
    }
}