// https://codeforces.com/contest/2060/problem/B

using System; using System.Collections; using System.Linq.Expressions;

class Program {
    static void test(int tc) {
        var vals = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = vals[0], m = vals[1];
        var st = new SortedSet<int>[n];
        for (int i = 0; i < n; ++i) {
            st[i] = new SortedSet<int>();
            var ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (var x in ar) st[i].Add(x);
        }
        var tp = new (int, int)[n];
        for (int i = 0; i < n; i++) tp[i] = (st[i].Min, i);
        Array.Sort(tp);
        for (int i = 0, k = 0; i < m; ++i) {
            foreach (var t in tp) {
                if (!st[t.Item2].Contains(k)) {
                    Console.WriteLine(-1); return;
                }
                ++k;
            }
        }
        foreach (var t in tp) Console.Write(t.Item2 + 1 + " ");
        Console.WriteLine();
    }

    const int M = 1000000007;
    static void Main(string[] args) {
        int tc = 0, tt = 1;
        tt = int.Parse(Console.ReadLine());
        while (tc++ < tt) test(tc);
    }
    static void pe<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }
    static void ps(bool b) { Console.WriteLine(b? "YES" : "NO"); }
    static void ck<T>(Expression<Func<T>> expression) {
        var body = (MemberExpression)expression.Body;
        string variableName = body.Member.Name;
        T value = expression.Compile().Invoke();
        Console.Error.Write($"{variableName} = ");
        if (value is IEnumerable enu && value is not string) {
            Console.Error.WriteLine($"[{string.Join(", ", enu.Cast<object>())}]");
        }
        else if (value is IDictionary dictionary) {
            foreach (DictionaryEntry ent in dictionary)
                Console.Error.WriteLine($"{ent.Key}: {ent.Value}");
        }
        else Console.Error.WriteLine(value);
    }
}