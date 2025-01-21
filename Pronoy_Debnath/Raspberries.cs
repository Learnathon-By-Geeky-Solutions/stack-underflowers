// https://codeforces.com/problemset/problem/1883/C

using System;

class Program {
    static void test(int tc) {
        // int n = int.Parse(Console.ReadLine());
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = nums[0], k = nums[1];
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int ans = int.MaxValue, even = 0;
        foreach (int i in ar) {
            int a = (i / k) + (i % k == 0? 0 : 1); a *= k;
            ans = Math.Min(ans, a - i);
            even += i % 2 == 0? 1 : 0;
        }
        if (k != 4) Console.Write(ans);
        else Console.Write(Math.Min(2 - Math.Min(2, even), ans));
        Console.WriteLine();
    }

    static void Main(string[] args) {
        int tc = 0, tt = 1;
        tt = int.Parse(Console.ReadLine());
        while (tc++ < tt) test(tc);
    }
    static void pe<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
    static void ps(bool b) { Console.WriteLine(b? "YES" : "NO"); }
}