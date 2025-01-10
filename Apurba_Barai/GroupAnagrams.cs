// Leetcode 49:Group Anagrams

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramDict = new Dictionary<string, List<string>>();
        List<IList<string>> result = new List<IList<string>>();

        foreach (string s in strs)
        {
            char[] sortedWordArray = s.ToCharArray();
            Array.Sort(sortedWordArray);
            string sortedWord = new string(sortedWordArray);

            if (!anagramDict.ContainsKey(sortedWord))
            {
                anagramDict[sortedWord] = new List<string>();
            }
            anagramDict[sortedWord].Add(s);
        }
        foreach (var value in anagramDict.Values)result.Add(value);
        return result;
    }
}