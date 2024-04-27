class Solution(object):
    def convert(self, s, numRows):
        """
        :type s: str
        :type numRows: int
        :rtype: str
        """
        if numRows == 1 or numRows >= len(s):
            return s

        rows = [''] * numRows
        curRow, step = 0, -1  

        for c in s:
            rows[curRow] += c
            if curRow == 0 or curRow == numRows - 1:
                step = -step
            curRow += step

        return ''.join(rows)