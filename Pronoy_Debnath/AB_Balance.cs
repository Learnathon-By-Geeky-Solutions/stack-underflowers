// https://codeforces.com/problemset/problem/1606/A

using System; using System.Collections; using System.Linq.Expressions;

class Program {
    static void test(int tc) {
        var s = Console.ReadLine().ToCharArray();
        int a = 0, b = 0, n = s.Length;
        for (int i = 0; i < n - 1; ++i) {
            if (s[i] == 'a' && s[i + 1] == 'b') ++a;
            if (s[i] == 'b' && s[i + 1] == 'a') ++b;
        }
        if (a < b) {
            for (int i = 0; i < n - 1; ++i) {
                if (s[i] == 'a' && s[i + 1] == 'a') {
                    s[i + 1] = 'b'; Console.WriteLine(s); return;
                }
                if (s[i] == 'b' && s[i + 1] == 'b') {
                    s[i] = 'a'; Console.WriteLine(s); return;
                }
                if (s[i] == 'b' && s[i + 1] == 'a') {
                    s[i] = 'a'; Console.WriteLine(s); return;
                }
            }
        }
        else if (b < a) {
            for (int i = 0; i < n - 1; ++i) {
                if (s[i] == 'b' && s[i + 1] == 'b') {
                    s[i + 1] = 'a'; Console.WriteLine(s); return;
                }
                if (s[i] == 'a' && s[i + 1] == 'a') {
                    s[i] = 'b'; Console.WriteLine(s); return;
                }
                if (s[i] == 'a' && s[i + 1] == 'b') {
                    s[i] = 'b'; Console.WriteLine(s); return;
                }
            }
        }
        else {
            Console.WriteLine(s);
        }
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