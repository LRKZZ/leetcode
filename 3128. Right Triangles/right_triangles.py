class Solution(object):
    def numberOfRightTriangles(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """
        rowCount = [0] * len(grid)
        colCount = [0] * len(grid[0])

        for i in range(len(grid)):
            for j in range(len(grid[0])):
                if grid[i][j] == 1:
                    rowCount[i] += 1
                    colCount[j] += 1

        numRightTriangles = 0
        for i in range(len(grid)):
            for j in range(len(grid[0])):
                if grid[i][j] == 1:
                    numRightTriangles += (rowCount[i] - 1) * (colCount[j] - 1)

        return numRightTriangles