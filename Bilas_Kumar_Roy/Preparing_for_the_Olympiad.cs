/* Problem link : https://codeforces.com/contest/2051/problem/A */
using System;
class Program {
    static void P_Solved() {
        int n = int.Parse(Console.ReadLine());
        int[] ar = new int[n + 1];
        int[] br = new int[n + 1];

        string[] arInput = Console.ReadLine().Split();
        for (int i = 1; i <= n; i++) ar[i] = int.Parse(arInput[i - 1]);

        string[] brInput = Console.ReadLine().Split();
        for (int i = 1; i <= n; i++) br[i] = int.Parse(brInput[i - 1]);

        int ans = ar[n];
        for (int i = 1; i < n; i++) {
            if (ar[i] > br[i + 1]) {
                ans += (ar[i] - br[i + 1]);
            }
        }
        Console.WriteLine(ans);
    }

    public static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0) {
            P_Solved();
        }
    }
}