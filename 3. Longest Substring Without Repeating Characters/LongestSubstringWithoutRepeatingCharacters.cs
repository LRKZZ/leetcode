public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<int> listOfCounts = new List<int>();

        string currentSubstring = "";

        foreach (char c in s) 
        {
            if (!currentSubstring.Contains(c))
            {
                currentSubstring += c;
            }
            else
            {
                listOfCounts.Add(currentSubstring.Length);
                int index = currentSubstring.IndexOf(c);
                currentSubstring = currentSubstring.Substring(index + 1) + c;
            }
        }
        listOfCounts.Add(currentSubstring.Length);
        int maxValue = listOfCounts.Count > 0 ? listOfCounts.Max() : 0;
        return maxValue;
        }
    }