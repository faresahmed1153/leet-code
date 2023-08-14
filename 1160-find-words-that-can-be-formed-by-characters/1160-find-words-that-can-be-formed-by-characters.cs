public class Solution {
    public int CountCharacters(string[] words, string chars) {
     Dictionary<char, int> dict = new Dictionary<char, int>();
            HashSet<char> set = new HashSet<char>();
            int CountCharacters = 0;
            bool partOfIt;
            bool found;
            for (int i = 0; i < chars.Length; i++)


                if (!dict.TryAdd(chars[i], 1))
                {
                    dict.TryGetValue(chars[i], out int value);
                    dict[chars[i]] = value + 1;
                }



            for (int i = 0; i < words.Length; i++)
            {
                partOfIt = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (set.Contains(words[i][j]))
                        continue;
                    found = dict.TryGetValue(words[i][j], out int value);
                    if (found)
                    {
                        if (words[i].Count(l => l == words[i][j]) <= value)
                        {
                            set.Add(words[i][j]);
                        }
                        else
                        {
                            partOfIt = false;
                            break;
                        }

                    }
                    else
                    {
                        partOfIt = false;
                        break;
                    }
                }

                if (partOfIt)
                    CountCharacters += words[i].Length;
                set.Clear();

            }        
            return CountCharacters;
    }
}