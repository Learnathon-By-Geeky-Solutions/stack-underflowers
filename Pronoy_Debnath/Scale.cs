// Problem 2: https://codeforces.com/problemset/problem/1996/B
// Solution:

using System;
class Program {
    static void test(int tc) {
        // int n = int.Parse(Console.ReadLine());
        int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = num[0], k = num[1];
        char[,] ar = new char[n, n];
        for (int i = 0; i < n; ++i) {
            string s = Console.ReadLine();
            for (int j = 0; j < n; ++j) ar[i, j] = s[j];
        }
        char[,] ans = new char[n / k, n / k];
        for (int i = 0, m = 0; i < n; i += k, ++m) {
            for (int j = 0, l = 0; j < n; j += k, ++l) ans[m, l] = ar[i, j];
        }
        for (int i = 0; i < n / k; ++i) {
            for (int j = 0; j < n / k; ++j) Console.Write(ans[i, j]);
            Console.WriteLine();
        }
    }

    static void Main(string[] args) {
        int tc = 0, tt = 1;
        tt = int.Parse(Console.ReadLine());
        while (tc++ < tt) test(tc);
    }
    static void pe<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
    static void ps(bool b) { Console.WriteLine(b ? "YES" : "NO"); }
}
