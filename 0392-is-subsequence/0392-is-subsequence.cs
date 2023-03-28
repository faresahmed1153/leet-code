public class Solution {
    public bool IsSubsequence(string s, string t) {
int count = 0;

            for (int i = 0; i < t.Length; i++)
                if (count < s.Length && s[count] == t[i])
                    count++;

            return count == s.Length;
}
}