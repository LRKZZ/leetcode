public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int[] flattenedMatrix = matrix.SelectMany(subArray => subArray).ToArray();

        bool isTargetPresent = flattenedMatrix.Contains(target);
        
        return isTargetPresent;
    }
}