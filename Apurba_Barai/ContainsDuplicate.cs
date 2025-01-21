// Leetcode 217.Contains Duplicate
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> s = new HashSet<int>();
        foreach (int n in nums) {
            if (s.Contains(n)) {
                return true;
            }
            s.Add(n);
        }
        return false;
    }
}