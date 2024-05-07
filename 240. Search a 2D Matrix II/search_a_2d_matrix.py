class Solution(object):
    def searchMatrix(self, matrix, target):
        """
        :type matrix: List[List[int]]
        :type target: int
        :rtype: bool
        """
        flattened_matrix = [element for row in matrix for element in row]

        is_target_present = target in flattened_matrix

        return is_target_present