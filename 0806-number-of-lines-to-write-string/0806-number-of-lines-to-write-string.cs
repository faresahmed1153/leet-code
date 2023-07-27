public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
       int sum = 0;
            string letters = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < letters.Length; i++)
                dic.Add(letters[i], widths[i]);

            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();
            int sumOfLastLine = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += dic.GetValueOrDefault(s[i]);
                sb.Append(s[i]);
                if (sum > 100)
                {
                    sum = 0;
                    sb.Remove(sb.Length - 1, 1);
                    list.Add(sb.ToString());
                    sb.Clear();
                    sum += dic.GetValueOrDefault(s[i]);
                    sb.Append(s[i]);

                }
                if (i == s.Length - 1)
                    list.Add(sb.ToString());
            }
            var lastLine = list[list.Count - 1];
            if (lastLine.Length == 2 && lastLine[0] == lastLine[1])
                sumOfLastLine += dic.GetValueOrDefault(lastLine.ElementAt(0));
            else
            {


                for (int i = 0; i < lastLine.Count(); i++)
                {



                    sumOfLastLine += dic.GetValueOrDefault(lastLine.ElementAt(i));

                }
            }
            int[] result = new int[] { list.Count, sumOfLastLine };
            return result;
    }
}