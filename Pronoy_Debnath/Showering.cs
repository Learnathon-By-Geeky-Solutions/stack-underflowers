// https://codeforces.com/problemset/problem/1999/C

using System;

class Program {
    static void test(int tc) {
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = ar[0], s = ar[1], m = ar[2], pre = 0;
        bool ok = false;
        while (n-- > 0) {
            int[] pair = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int l = pair[0], r = pair[1];
            if (l - pre >= s) ok = true;
            pre = r;
        }
        ok |= (m - pre >= s);
        ps(ok);
    }

    static void Main(string[] args) {
        int tc = 0, tt = 1;
        tt = int.Parse(Console.ReadLine());
        while (tc++ < tt) test(tc);
    }
    static void pe<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
    static void ps(bool condition) { Console.WriteLine(condition ? "YES" : "NO"); }
}
