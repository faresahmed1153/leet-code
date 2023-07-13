public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int index;
            if (ruleKey == "type")
                index = 0;
            else if (ruleKey == "color")
                index = 1;
            else
                index = 2;
            int count = items.Where((item) => item[index] == ruleValue).Count();
            return count;
    }
}