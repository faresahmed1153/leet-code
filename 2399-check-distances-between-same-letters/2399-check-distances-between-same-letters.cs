public class Solution {
    public bool CheckDistances(string s, int[] distance) {
        
        string letters = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int distanceBetween;
            bool checkDistance;
            for (int i = 0; i < letters.Length; i++)
                dic.Add(letters[i], i);

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        distanceBetween = j - i - 1;
                        if (distance[dic.GetValueOrDefault(s[i])] != distanceBetween)
                        {
                            checkDistance = false;
                            
                            return checkDistance;
                        }

                    }
                    

                }
            }
         return checkDistance = true ;
            
        
    }
}