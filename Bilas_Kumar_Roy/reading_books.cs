/* Reading books from CSES Problem Set */
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void P_Solved()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> v = new List<int>(n);
        long sum = 0;

        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine());
            v.Add(value);
            sum += value;
        }

        v.Sort();
        if (sum - v[n - 1] >= v[n - 1])
            Console.WriteLine(sum);
        else
            Console.WriteLine(2L * v[n - 1]);
    }

    public static void Main(string[] args)
    {
        int t = 1;
        while (t-- > 0)
        {
            P_Solved();
        }
    }
}