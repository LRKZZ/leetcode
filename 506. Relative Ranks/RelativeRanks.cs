public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        string[] result = new string[score.Length];

        int[] idxs = score.Select((value, index) => new { Value = value, Index = index })
                          .OrderByDescending(v => v.Value)
                          .Select(v => v.Index)
                          .ToArray();
                          
        for (int i = 0; i < idxs.Length; i++) {
            switch (i) {
                case 0:
                    result[idxs[i]] = "Gold Medal";
                    break;
                case 1:
                    result[idxs[i]] = "Silver Medal";
                    break;
                case 2:
                    result[idxs[i]] = "Bronze Medal";
                    break;
                default:
                    result[idxs[i]] = (i + 1).ToString();
                    break;
            }
        }
        
        return result;
    }
}