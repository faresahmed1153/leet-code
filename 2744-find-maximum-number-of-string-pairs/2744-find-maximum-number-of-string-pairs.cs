public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int count = 0;

            for (int i = 0; i < words.Length; i++)

                for (int j = i + 1; j < words.Length; j++)
                    if (words[i] == string.Create(words[j].Length, words[j], (chars, state) =>
                    {
                        state.AsSpan().CopyTo(chars);
                        chars.Reverse();
                    }))
                        count++;


            return count;
    }
}