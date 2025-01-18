// https://codeforces.com/problemset/problem/1907/B

using System; using System.Collections; using System.Linq.Expressions;

class Program {
    static void test(int tc) {
        // var vals = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        // int n = vals[0];
        // var ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var s = Console.ReadLine();
        var n = s.Length;
        var ig = new List<int>();
        var lo = new List<int>();
        var up = new List<int>();
        for (int i = 0; i < n; ++i) {
            if (s[i] == 'b') {
                if (lo.Any()) {
                    ig.Add(lo.Last());
                    lo.RemoveAt(lo.Count - 1);
                }
                ig.Add(i);
            }
            else if (s[i] == 'B') {
                if (up.Any()) {
                    ig.Add(up.Last());
                    up.RemoveAt(up.Count - 1);
                }
                ig.Add(i);
            }
            else if (char.IsLower(s[i])) lo.Add(i);
            else up.Add(i);
        }
        int j = 0, sz = ig.Count(); ig.Sort();
        for (int i = 0; i < n; ++i) {
            if (j < sz && i == ig[j]) ++j;
            else Console.Write(s[i]);
        }
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