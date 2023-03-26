public class Solution {
    public int LengthOfLastWord(string s) {
        var splitted = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var last = splitted[splitted.Length - 1];
            return last.Length;
    }
}