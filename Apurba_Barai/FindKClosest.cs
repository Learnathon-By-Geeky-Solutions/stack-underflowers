// Leetcode 658:Find K Closest Elements

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        int n = arr.Length;
        int[] absArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            absArr[i] = Math.Abs(x - arr[i]);
        }

        int absSum = 0;
        for (int i = 0; i < k; i++)
        {
            absSum += absArr[i];
        }

        int prev = absSum;
        int minIndex = 0;

        for (int i = 1; i <= n - k; i++)
        {
            absSum = absSum + absArr[i + k - 1] - absArr[i - 1];
            if (absSum < prev)
            {
                minIndex = i;
                prev = absSum;
            }
        }
        List<int> result = new List<int>();
        for (int i = minIndex; i < minIndex + k; i++)
        {
            result.Add(arr[i]);
        }
        return result;
    }
}