public class Solution {
    public int RomanToInt(string s) {
        var translations = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int number = 0;

        s = s.Replace("IV", "IIII").Replace("IX", "VIIII");
        s = s.Replace("XL", "XXXX").Replace("XC", "LXXXX");
        s = s.Replace("CD", "CCCC").Replace("CM", "DCCCC");

        foreach (var chart in s) {
            number += translations[chart];
        }

        return number;
    }
}