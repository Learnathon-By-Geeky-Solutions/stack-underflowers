/* Codeforces Round 998 (Div. 3) Problem : D */

using System;
class Program {
    static void p_solved() {
        int n = int.Parse(Console.ReadLine());
        int[] ar = new int[n];
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            ar[i] = int.Parse(input[i]);
        }
        for (int i = 0; i + 1 < n; i++)
        {
            if (ar[i] > ar[i + 1])
            {
                Console.WriteLine("NO");
                return;
            }
            int mn = Math.Min(ar[i], ar[i + 1]);
            ar[i + 1] -= mn;
        }
        Console.WriteLine("YES");
    }
    public static void Main(string[] args) {
        int t = 1;
        t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            p_solved();
        }
    }
}

