// https://codeforces.com/problemset/problem/1995/A

using System; using System.Collections; using System.Linq.Expressions;

class Program {
    static void test(int tc) {
        var vals = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = vals[0], k = vals[1];
        if (k == 0) {
            Console.WriteLine(0);
            return;
        }
        if (k <= n) {
            Console.WriteLine(1);
            return;
        }
        k -= n; int c = 2, d = n - 1;
        while (k > 0) {
            k -= d;
            if (k <= 0) {
                Console.WriteLine(c);
                return;
            }
            ++c; k -= d;
            if (k <= 0) {
                Console.WriteLine(c);
                return;
            }
            ++c; --d;
        }
        Console.WriteLine(c);
        // Console.WriteLine();
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