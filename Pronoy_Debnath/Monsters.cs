using System;

class Program {
    static void test(int tc) {
        char[] s = Console.ReadLine().ToCharArray();
        string r = Console.ReadLine();
        int n = s.Length, m = r.Length;
        int i = 0;
        for (int j = 0; j < n; ++j) {
            ref var c = ref s[j];
            if (i == m) break;
            if (c == r[i]) ++i;
            else if (c == '?') {
                c = r[i]; ++i;
            }
        }
        if (i == m) {
            ps(true);
            foreach (var c in s) Console.Write(c == '?'? 'a' : c);
            Console.WriteLine();
        } else ps(false);
    }

    const int M = 1000000007;
    static void Main(string[] args) {
        int tc = 0, tt = 1;
        tt = int.Parse(Console.ReadLine());
        while (tc++ < tt) test(tc);
    }
    static void pe<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
    static void ps(bool b) { Console.WriteLine(b? "YES" : "NO"); }
}