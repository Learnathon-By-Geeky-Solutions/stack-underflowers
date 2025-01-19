/* Problem link : https://codeforces.com/contest/1263/problem/C */
using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void PrintDivisors() {
        int number; 
        number = Convert.ToInt32(Console.ReadLine());
        List<int> divisors = new List<int> { 0 };

        for (int i = 1; i * i <= number; i++)
        {
            divisors.Add(i);
            if (i != number / i) 
                divisors.Add(number / i);
        }

        divisors.Sort();
        Console.WriteLine(divisors.Count);
        Console.WriteLine(string.Join(" ", divisors));
    }

    public static void Main(string[] args) {
        int testCases = 1;
        testCases = Convert.ToInt32(Console.ReadLine());
        while (testCases-- > 0)
        {
            PrintDivisors();
        }
    }
}
