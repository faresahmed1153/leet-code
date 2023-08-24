public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        StringBuilder sb = new StringBuilder(words[0][0].ToString());
            for (int i = 1; i < words.Count; i++)
                sb.Append(words[i][0]);
            return sb.ToString() == s;
    }
}