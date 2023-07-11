public class Solution {
    public string RestoreString(string s, int[] indices) {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                sb.Remove(indices[i], 1);
                sb.Insert(indices[i], s[i]);
            }
           
          return sb.ToString();
    }
}