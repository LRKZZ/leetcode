class Solution(object):
    def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        INT_MAX = 2**31 - 1
        INT_MIN = -2**31

        rev = 0
        sign = [1, -1][x < 0]
        x_abs = abs(x)

        while x_abs != 0:
            pop = x_abs % 10
            x_abs //= 10
            rev = rev * 10 + pop
            if rev > INT_MAX or rev < INT_MIN:
                return 0

        return sign * rev