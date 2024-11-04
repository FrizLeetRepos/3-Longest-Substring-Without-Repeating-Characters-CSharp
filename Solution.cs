public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        int start = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (dict.ContainsKey(s[i])) {
                start = Math.Max(start, dict[s[i]] + 1);
            }
            dict[s[i]] = i;
            max = Math.Max(max, i - start + 1);
        }
        return max;

    }
}