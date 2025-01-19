/* https://codeforces.com/contest/2060/problem/C */
using System;
using System.Collections.Generic;

class Program {
    static void P_Solved() {
        int n, k;
        var input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        k = int.Parse(input[1]);
        
        Dictionary<int, int> mp = new Dictionary<int, int>();
        string[] v = Console.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            int x = int.Parse(v[i-1]);
            
            if (mp.ContainsKey(x))
            {
                mp[x]++;
            }
            else
            {
                mp[x] = 1;
            }
        }

        long ans = 0;
        for (int i = 1; i <= k / 2; i++)
        {
            if (i + i == k)
            {
                ans += mp.ContainsKey(i) ? mp[i] / 2 : 0;
            }
            else
            {
                ans += Math.Min(mp.ContainsKey(i) ? mp[i] : 0, mp.ContainsKey(k - i) ? mp[k - i] : 0);
            }
        }
        Console.WriteLine(ans);
    }

    public static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            P_Solved();
        }
    }
}

