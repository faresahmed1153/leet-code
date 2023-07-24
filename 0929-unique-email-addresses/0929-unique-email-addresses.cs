public class Solution {
    public int NumUniqueEmails(string[] emails) {
     List<string> filteredEmails = new List<string>();

            for (int i = 0; i < emails.Length; i++)
            {
                if (emails[i].Split("@")[0].Contains("+"))
                {
                    string removedPlus = emails[i].Remove(emails[i].IndexOf("+"), emails[i].IndexOf("@") - emails[i].IndexOf("+"));
                    string beforeDomain = removedPlus.Split("@")[0];
                    string removedDot = beforeDomain.Replace(".", string.Empty);
                    string addDomain = string.Concat(removedDot, "@", emails[i].Split("@")[1]);
                    filteredEmails.Add(addDomain);
                }
                else
                {
                    string beforeDomain = emails[i].Split("@")[0];
                    string removedDot = beforeDomain.Replace(".", string.Empty);
                    string addDomain = string.Concat(removedDot, "@", emails[i].Split("@")[1]);
                    filteredEmails.Add(addDomain);

                }

            }

            return filteredEmails.Distinct().Count();
}
}