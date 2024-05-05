public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();

        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string reversed_s = new string(charArray);

        return s == reversed_s;
    }
}