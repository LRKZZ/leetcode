class Solution(object):
    def isPalindrome(self, x):
        """
        :type x: int
        :rtype: bool
        """
        reversed_x = str(x)[::-1]

        if str(reversed_x) == str(x):
            return True
        else:
            return False


        