
// Leetcode 1652.Defuse the bomb
public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int n = code.Length;
        int[] result = new int[n];
        if (k == 0) {
            return new int[n];
        }
        if (k > 0) {
            for (int i = 0; i < n; i++) {
                int sum = 0;
                for (int j = 1; j <= k; j++) {
                    sum += code[(i + j) % n];
                }
                result[i] = sum;
            }
        }
        if (k < 0) {
            for (int i = 0; i < n; i++) {
                int sum = 0;
                int c = Math.Abs(k);
                int j = i;
                while (c > 0) {
                    j = (j - 1 + n) % n; 
                    sum += code[j];
                    c--;
                }
                result[i] = sum;
            }
        }
        return result;
    }
}