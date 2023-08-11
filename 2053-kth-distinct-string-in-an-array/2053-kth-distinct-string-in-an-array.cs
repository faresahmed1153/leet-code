public class Solution {
    public string KthDistinct(string[] arr, int k) {
      string[] distinctArr = arr.GroupBy(w => w).Where(w => w.Count() == 1).Select(w => w.Key).ToArray();
            
            return distinctArr.Length >= k ? distinctArr[k - 1] : string.Empty;
    }
}