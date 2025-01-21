/* Prob link : https://cses.fi/problemset/task/1085/ */
using System;

class Program {
    static void Solved() {
        int n, k;
        string[] input = Console.ReadLine().Split();
        n = Convert.ToInt32(input[0]);
        k = Convert.ToInt32(input[1]);
        int[] array = new int[n+1];
        int lo = -1;
        long Sum = 0;
        input = Console.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            array[i] = Convert.ToInt32(input[i-1]);
            Sum += array[i];
            lo = Math.Max(lo,array[i]);
        }
        long lw = lo;
        long hi = Sum;
        long ans = -1;

        while (lw <= hi)
        {
            long mid = hi - (hi - lw) / 2;
            int tk = 1;
            long currentSum = 0;
            for (int i = 1; i <= n; i++)
            {
                currentSum += array[i];
                if (currentSum > mid)
                {
                    tk++;
                    currentSum = array[i];
                }
            }
            if (tk <= k)
            {
                ans = mid;
                hi = mid - 1;
            }
            else
            {
                lw = mid + 1;
            }
        }
        Console.WriteLine(ans);
    }

    public static void Main(string[] args) {
        Solved();
    }
}
