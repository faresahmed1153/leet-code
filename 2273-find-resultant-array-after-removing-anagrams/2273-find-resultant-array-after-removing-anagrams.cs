public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
             List<string> RemoveAnagrams = new List<string>(words);
            Dictionary<char, int> currentWord = new Dictionary<char, int>();
            Dictionary<char, int> nextWord = new Dictionary<char, int>();
            bool isAnagram;

            for (int i = 0; i < RemoveAnagrams.Count - 1; i++)
            {
                isAnagram = true;

                if (RemoveAnagrams[i].Length != RemoveAnagrams[i + 1].Length)
                    continue;

                for (int j = 0; j < RemoveAnagrams[i].Length; j++)
                {
                    bool currentAdded = currentWord.TryAdd(RemoveAnagrams[i][j], 1);
                    bool nextAdded = nextWord.TryAdd(RemoveAnagrams[i + 1][j], 1);
                    if (!currentAdded)
                    {
                        currentWord.TryGetValue(RemoveAnagrams[i][j], out int currentvalue);
                        currentWord[RemoveAnagrams[i][j]] = currentvalue + 1;
                    }
                    if (!nextAdded)
                    {
                        nextWord.TryGetValue(RemoveAnagrams[i + 1][j], out int nextvalue);
                        nextWord[RemoveAnagrams[i + 1][j]] = nextvalue + 1;
                    }
                }

                for (int k = 0; k < RemoveAnagrams[i].Length; k++)
                {
                     if (!RemoveAnagrams[i].Contains(RemoveAnagrams[i + 1][k]))
                    {
                        isAnagram = false;
                        currentWord.Clear();
                        nextWord.Clear();
                        break;
                    }
                    currentWord.TryGetValue(RemoveAnagrams[i][k], out int currentvalue);
                    nextWord.TryGetValue(RemoveAnagrams[i][k], out int nextvalue);
                   
                    if (currentvalue != nextvalue)
                    {
                        isAnagram = false;
                        currentWord.Clear();
                        nextWord.Clear();
                        break;
                    }
                }

                if (isAnagram)
                {
                    RemoveAnagrams.Remove(RemoveAnagrams[i + 1]);
                    i = -1;
                    currentWord.Clear();
                    nextWord.Clear();
                }

            }
            return RemoveAnagrams;
    }
}