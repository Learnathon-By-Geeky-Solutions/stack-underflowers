/* Problem link : https://codeforces.com/contest/1197/problem/C */
using System;
using System.Linq;

class Program
{
    const int MX = 300005;
    static int[] ar = new int[MX];
    static int[] dif = new int[MX];

    static void p_solved()
    {
        int n, k;
        var input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        k = int.Parse(input[1]);

        input = Console.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            ar[i] = int.Parse(input[i - 1]);
        }

        for (int i = 1; i < n; i++)
        {
            dif[i] = ar[i] - ar[i + 1];
        }

        Array.Sort(dif, 1, n - 1);
        int ans = ar[n] - ar[1];
        for (int i = 1; i < k; i++)
        {
            ans += dif[i];
        }

        Console.WriteLine(ans);
    }

    public static void Main(string[] args) {
        int t = 1;
        while (t-- > 0)
        {
            p_solved();
        }
    }
}

