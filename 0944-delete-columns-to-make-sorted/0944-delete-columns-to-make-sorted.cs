public class Solution {
    public int MinDeletionSize(string[] strs) {
    
           StringBuilder sb = new StringBuilder();
            int count = 0;
                for (int i = 0; i < strs[0].Length; i++)
                {
                    for (int j = 0; j < strs.Length; j++)
                    {
                        sb.Append(strs[j][i]);
                    }
                    string colmun = sb.ToString();
                    if (colmun != string.Concat(colmun.OrderBy(ch => ch)))
                        count++;
                    sb.Clear();
                }
            
            return count;
    }
}