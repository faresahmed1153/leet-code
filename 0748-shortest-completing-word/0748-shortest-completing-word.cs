using System.Text.RegularExpressions;
public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        string licensePlateWithoutNumber = Regex.Replace(licensePlate, @"[\d-]", string.Empty);
            string licensePlateWithoutNumberAndSpace = Regex.Replace(licensePlateWithoutNumber, " ", "").ToLower();
            List<char> list = new List<char>(licensePlateWithoutNumberAndSpace);
            int index = 0;
            int length = 0;
            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)


                    if (list.Contains(words[i][j]))
                        list.Remove(words[i][j]);
                if (list.Count == 0 && found == false)
                {
                    index = i;
                    length = words[i].Length;
                    found = true;
                }

                if (list.Count == 0 && found == true)
                    if (words[i].Length < length)
                    {
                        index = i;
                        length = words[i].Length;

                    }

                list.Clear();
                list.AddRange(licensePlateWithoutNumberAndSpace);

            }

            return words[index];
    }
}