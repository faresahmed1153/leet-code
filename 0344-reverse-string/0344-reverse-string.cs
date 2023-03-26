public class Solution {
    public void ReverseString(char[] s) {
      int j = s.Length - 1;
            for (int i = 0; i < j; i++)
            {
                var temp = s[i];
                char x = s[i] = s[j];
                char y = s[j] = temp;
                j--;
            }
            
    }
}