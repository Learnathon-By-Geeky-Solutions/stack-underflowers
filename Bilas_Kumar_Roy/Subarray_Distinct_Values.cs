/* Prob link : https://cses.fi/problemset/task/2428/ */
using System;
using System.Collections.Generic;

class Program {
    static void SolveProblem()
    {
        int n, k;
        string[] input = Console.ReadLine().Split();
        n = Convert.ToInt32(input[0]);
        k = Convert.ToInt32(input[1]);

        int[] array = new int[n];
        input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(input[i]);
        }

        int l = 0, r = 0;
        Dictionary<int, int> mp = new Dictionary<int, int>();
        int distinctCount = 0;
        long ans = 0;

        while (r < n)
        {
            if (!mp.ContainsKey(array[r]))
            {
                distinctCount++;
            }
            mp[array[r]] = mp.GetValueOrDefault(array[r], 0) + 1;

            while (distinctCount > k)
            {
                mp[array[l]]--;
                if (mp[array[l]] == 0)
                {
                    mp.Remove(array[l]);
                    distinctCount--;
                }
                l++;
            }

            ans += r - l + 1;
            r++;
        }

        Console.WriteLine(ans);
    }
    public static void Main(string[] args) {
        SolveProblem();
    }
}
