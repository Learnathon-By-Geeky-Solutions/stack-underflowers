// https://codeforces.com/problemset/problem/1997/A

using System;

class Program {
    static char mismatch(char ch) {
        for (char c = 'a'; c <= 'z'; c++) {
            if (c != ch) {
                return c;
            }
        }
        return 'z';
    }
    static void test(int tc) {
        // int n = int.Parse(Console.ReadLine());
        // int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length - 1; i++) {
            if (s[i] == s[i + 1]) {
                Console.WriteLine(s[..(i + 1)] + mismatch(s[i]) + s[(i + 1)..]);
                return;
            }
        }
        Console.WriteLine(s + mismatch(s[^1]));
    }

    static void Main(string[] args) {
        int tc = 0, tt = 1;
        tt = int.Parse(Console.ReadLine());
        while (tc++ < tt) test(tc);
    }
    static void pe<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
    static void ps(bool b) { Console.WriteLine(b ? "YES" : "NO"); }
}