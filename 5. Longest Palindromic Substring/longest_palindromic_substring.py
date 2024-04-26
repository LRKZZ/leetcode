class Solution(object):
    def longestPalindrome(self, s):
        def expandAroundCenter(left, right):
            while left >= 0 and right < len(s) and s[left] == s[right]:
                left -= 1
                right += 1
            return s[left + 1:right]

        if len(s) <= 1:
            return s
        
        maxPal = ""
        for i in range(len(s)):
            pal1 = expandAroundCenter(i, i)
            if len(pal1) > len(maxPal):
                maxPal = pal1

            pal2 = expandAroundCenter(i, i + 1)
            if len(pal2) > len(maxPal):
                maxPal = pal2

        return maxPal
        