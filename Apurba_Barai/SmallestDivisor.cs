// Leetcode 1283:Find the Smallest Divisor Given a Threshold

using System;
using System.Collections.Generic;

public class Solution
{
    public int SmallestDivisor(int[] nums, int threshold)
    {
        bool Condition(int n)
        {
            long sum = 0;
            foreach (var num in nums) sum += (int)Math.Ceiling((double)num / n);
            return sum <= threshold;
        }
        int l = 1, r = 1;
        while (true)
        {
            if (!Condition(r))r *= 2;
            else break;
        }
        int left = l, right = r;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (Condition(mid))right = mid;
            else left = mid + 1;
        }
        return left;
    }
}
