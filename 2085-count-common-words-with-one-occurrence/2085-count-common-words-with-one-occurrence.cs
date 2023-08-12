public class Solution {
    public int CountWords(string[] words1, string[] words2) {
              int countWords = 0;
            int countOfCurrentWord;
            string[] words3 = words1.GroupBy(word => word).Where(word => word.Count() == 1).Select(word => word.Key).ToArray();
            List<string> commonWordsWithOneOccurrence = new List<string>();

            for (int i = 0; i < words3.Length; i++)
            {
                countOfCurrentWord = 0;
                for (int j = 0; j < words2.Length; j++)
                {
                    if (countOfCurrentWord > 1)
                        break;
                    if (words3[i] == words2[j])
                        countOfCurrentWord++;
                }
                if (countOfCurrentWord == 1)
                    commonWordsWithOneOccurrence.Add(words3[i]);
            }
        return commonWordsWithOneOccurrence.Count;
    }
}