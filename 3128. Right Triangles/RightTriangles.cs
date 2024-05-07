public class Solution {
    public long NumberOfRightTriangles(int[][] grid) {
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        int[] rowSums = new int[rowCount];
        int[] colSums = new int[colCount];

        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                if (grid[i][j] == 1) {
                    rowSums[i]++;
                    colSums[j]++;
                }
            }
        }

        long totalTriangles = 0;

        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                if (grid[i][j] == 1) {

                    totalTriangles += (long)(rowSums[i] - 1) * (colSums[j] - 1);
                }
            }
        }

        return totalTriangles;
    }
}