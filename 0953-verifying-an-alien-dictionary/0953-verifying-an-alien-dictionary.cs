public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        
       Dictionary<char, int> alien = new Dictionary<char, int>();
            bool IsAlienSorted = true;
            int orderOfCurrentChar;
            int orderOfNextChar;
            for (int i = 0; i < order.Length; i++)
                alien.Add(order[i], i);

            for (int i = 0; i < words.Length - 1; i++)
            {

                for (int j = 0; j < words[i].Length; j++)
                {
                    alien.TryGetValue(words[i][j], out orderOfCurrentChar);
                    if (j >= words[i + 1].Length)
                    {
                        orderOfNextChar = -1;
                    }
                    else
                    {
                        alien.TryGetValue(words[i + 1][j], out orderOfNextChar);
                    }

                    if (orderOfCurrentChar < orderOfNextChar)
                    {

                        break;
                    }
                    else if (orderOfNextChar < orderOfCurrentChar)
                    {
                        IsAlienSorted = false;
                        break;
                    }
                   
                    
                }
                if (!IsAlienSorted)
                        break;
            }
            return IsAlienSorted;
    }
}