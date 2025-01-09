// https://codeforces.com/problemset/problem/1993/A

using System;
class Program {
    static void test(int tc) {
        int n = int.Parse(Console.ReadLine());
        // int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        string s = Console.ReadLine();
        int[] ar = new int[4];
        foreach (char c in s) {
            if (c != '?') ++ar[c - 'A'];
        }
        int tot = 0;
        foreach (int e in ar) tot += Math.Min(n, e);
        Console.Write(tot);
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
