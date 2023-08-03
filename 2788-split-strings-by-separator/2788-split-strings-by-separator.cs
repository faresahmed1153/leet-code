public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
var splited = words.SelectMany(word => word.Trim().Split(separator)).Where(word => word != string.Empty);
            return splited.ToList();
    }
}