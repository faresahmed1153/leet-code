public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
    
        int sumOfIndex = 100000000;
            List<string> list = new List<string>();
            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list1[i]==list2[j])
                    {
                        if (i + j < sumOfIndex)
                        {
                            sumOfIndex = i + j;
                            list.Clear();
                            list.Add(list1[i]);


                        }
                        else if (i + j == sumOfIndex)
                        {
                            sumOfIndex = i + j;
                            list.Add(list1[i]);
                        }
                    }
                }
            }
            return list.ToArray();
        
    }
}