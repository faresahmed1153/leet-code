public class Solution {
    public char FindTheDifference(string s, string t) {
     
       char added = ' ';
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else frequency[c] = 1;
            }



            foreach (char c in t)
            {
                if (!frequency.ContainsKey(c) || frequency[c]==0)
                {
                    added = c;
                    break;
                }
                frequency[c]--;
            }
            return added;
    }
}