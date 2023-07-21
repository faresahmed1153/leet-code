public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
            for (int i = 0; i < details.Length; i++)

                if (int.Parse(string.Concat(details[i].Where((x, Index) => Index > 10 && Index < 13))) > 60)
                    count++;

            return count;
    }
}