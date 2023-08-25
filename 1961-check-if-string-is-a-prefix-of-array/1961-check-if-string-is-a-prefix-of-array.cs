public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        StringBuilder sb = new StringBuilder(words[0].ToString());
        if (sb.ToString() == s)
                    return sb.ToString() == s;
            for (int i = 1; i < words.Length; i++)
            {
                sb.Append(words[i]);
                if (sb.ToString() == s)
                    return sb.ToString() == s;
            }
            
            return sb.ToString()==s;
    }
}