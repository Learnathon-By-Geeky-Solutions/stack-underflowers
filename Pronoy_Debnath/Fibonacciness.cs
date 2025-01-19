// https://codeforces.com/contest/2060/problem/A

using System; using System.Collections; using System.Linq.Expressions;

class Program {
    static void test(int tc) {
        int n = 5;
        var ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var ls = new List<int>();
        ls.Add(ar[0]);
        ls.Add(ar[1]);
        ls.Add(ar[0] + ar[1]);
        ls.Add(ar[2]);
        ls.Add(ar[3]);
        int a = (ls[0] + ls[1] == ls[2] ? 1 : 0);
        a += (ls[1] + ls[2] == ls[3] ? 1 : 0);
        a += (ls[2] + ls[3] == ls[4] ? 1 : 0);
        ls[2] = ls[3] - ls[1];
        int b = (ls[0] + ls[1] == ls[2] ? 1 : 0);
        b += (ls[1] + ls[2] == ls[3] ? 1 : 0);
        b += (ls[2] + ls[3] == ls[4] ? 1 : 0);
        Console.Write(Math.Max(a, b));
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