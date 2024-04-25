class Solution(object):
    def findMedianSortedArrays(self, nums1, nums2):
        combined_list = nums1 + nums2
        combined_list.sort()
        
        if len(combined_list) % 2 == 0:
            i = len(combined_list) // 2
            result = (combined_list[i-1] + combined_list[i]) / 2.0
            return result
        else:
            i = len(combined_list) // 2
            return combined_list[i]