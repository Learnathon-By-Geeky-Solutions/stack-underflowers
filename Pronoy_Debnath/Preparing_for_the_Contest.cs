// https://codeforces.com/problemset/problem/1914/B

using System;

class Program {
    static void test(int tc) {
        // int n = int.Parse(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = ar[0], k = ar[1];
        int l = n - k;
        for (int i = l; i <= n; ++i) Console.Write(i + " ");
        for (int i = l - 1; i > 0; --i) Console.Write(i + " ");
        Console.WriteLine();
    }

    static void Main(string[] args) {
        int tc = 0, tt = 1;
        tt = int.Parse(Console.ReadLine());
        while (tc++ < tt) test(tc);
    }
    static void pe<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
    static void ps(bool b) { Console.WriteLine(b ? "YES" : "NO"); }
}
