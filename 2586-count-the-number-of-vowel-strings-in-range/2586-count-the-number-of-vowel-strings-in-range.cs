public class Solution {
    public int VowelStrings(string[] words, int left, int right) {
        string vowel = "aeiou";
            int count = 0;
            for (int i = left; i <= right; i++)

                if (vowel.Contains(words[i][0]) && vowel.Contains(words[i][words[i].Length - 1]))
                    count++;

            return count;
    }
}