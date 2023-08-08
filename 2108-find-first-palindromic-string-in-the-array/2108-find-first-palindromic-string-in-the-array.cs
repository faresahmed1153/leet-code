public class Solution {
    public string FirstPalindrome(string[] words) {
        for (int i = 0; i < words.Length; i++)
            
                if (words[i] == string.Concat(words[i].Reverse()))
                    return words[i];
                   
            return string.Empty;
    }
}