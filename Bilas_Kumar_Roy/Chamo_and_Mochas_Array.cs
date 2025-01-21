/* Prob link : https://codeforces.com/contest/1975/problem/C */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learn_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0) {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] ar = new int[n]; 
                var str = Console.ReadLine().Split(' ');
                for(int i=0; i<n; i++) {
                    ar[i] = Convert.ToInt32(str[i]);
                }
                if(n < 3) {
                    Console.WriteLine(Math.Min(ar[0], ar[1]));
                    continue;
                }
                int ans = 0;
                for(int i=2; i<n; i++) {
                    int[] vr = new int[3];
                    vr[0] = ar[i - 2];
                    vr[1] = ar[i - 1];
                    vr[2] = ar[i - 0];
                    Array.Sort(vr);
                    ans = Math.Max(ans, vr[1]);
                }
                Console.WriteLine(ans);
            }
        }
    }
}
