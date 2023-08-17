public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {
        Dictionary<char, int> keyValuePairs = new Dictionary<char, int>
            {
                { keysPressed[0], releaseTimes[0] }
            };
            for (int i = 0; i < releaseTimes.Length - 1; i++)
            {

                KeyValuePair<char, int> currentLongest = keyValuePairs.FirstOrDefault();
                if (releaseTimes[i + 1] - releaseTimes[i] > currentLongest.Value)
                {
                    keyValuePairs.Remove(currentLongest.Key);
                    keyValuePairs.Add(keysPressed[i + 1], releaseTimes[i + 1] - releaseTimes[i]);
                }

                else if (releaseTimes[i + 1] - releaseTimes[i] == currentLongest.Value)
                    if (keysPressed[i + 1] > currentLongest.Key)
                    {
                        keyValuePairs.Remove(currentLongest.Key);
                        keyValuePairs.Add(keysPressed[i + 1], releaseTimes[i + 1] - releaseTimes[i]);
                    }


            }
           return keyValuePairs.FirstOrDefault().Key;
    }
}