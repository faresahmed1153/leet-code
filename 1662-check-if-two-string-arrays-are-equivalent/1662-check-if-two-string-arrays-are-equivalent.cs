public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string w1 = String.Concat(word1);
            string w2 = String.Concat(word2);
            return w1 == w2;
    }
}