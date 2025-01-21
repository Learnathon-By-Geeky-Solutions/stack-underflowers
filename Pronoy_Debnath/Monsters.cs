// https://codeforces.com/problemset/problem/1849/B

using System; using System.Collections; using System.Linq.Expressions;

class Program {
    static void test(int tc) {
        var vals = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = vals[0], k = vals[1];
        var ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var tp = new List<(int, int)>();
        for (int i = 0; i < n; ++i) tp.Add((ar[i] % k == 0? k : ar[i] % k, i));
        tp.Sort(cmp);
        foreach (var t in tp) Console.Write(t.Item2 + 1 + " ");
        Console.WriteLine();
    }

    const int M = 1000000007;
    static int cmp((int, int) a, (int, int) b) {
        if (a.Item1 == b.Item1) return a.Item2.CompareTo(b.Item2);
        return b.Item1.CompareTo(a.Item1);
    }
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