public class Solution {
    public string FirstPalindrome(string[] words) {
        for (int i = 0; i < words.Length; i++)
            
                if (words[i] == string.Create(words[i].Length, words[i], (chars, state) =>
                {
                    state.AsSpan().CopyTo(chars);
                    chars.Reverse();
                }))
                    
                    return words[i];
                   
            return string.Empty;
    }
}