class Solution(object):
    def findRelativeRanks(self, score):
        """
        :type score: List[int]
        :rtype: List[str]
        """
        sorted_scores = sorted([(s, i) for i, s in enumerate(score)], reverse=True)

        result = ["" for _ in score]

        for rank, (s, i) in enumerate(sorted_scores, 1):
            if rank == 1:
                result[i] = "Gold Medal"
            elif rank == 2:
                result[i] = "Silver Medal"
            elif rank == 3:
                result[i] = "Bronze Medal"
            else:
                result[i] = str(rank)
        
        return result