public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int count = 0;
            for (int i = 0; i < words.Length; i++)

            if (words[i].Length>=pref.Length&&words[i].Substring(0, pref.Length) == pref)
                    count++;
            return count;
    }
}