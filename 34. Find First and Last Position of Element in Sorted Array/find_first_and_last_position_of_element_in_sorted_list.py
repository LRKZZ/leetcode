class Solution(object):
    def searchRange(self, nums, target):
        def findStart(nums, target):
            index = -1
            left, right = 0, len(nums) - 1
            
            while left <= right:
                mid = left + (right - left) // 2
                if nums[mid] == target:
                    index = mid
                    right = mid - 1
                elif nums[mid] < target:
                    left = mid + 1
                else:
                    right = mid - 1
            
            return index
        
        def findEnd(nums, target):
            index = -1
            left, right = 0, len(nums) - 1
            
            while left <= right:
                mid = left + (right - left) // 2
                if nums[mid] == target:
                    index = mid
                    left = mid + 1
                elif nums[mid] < target:
                    left = mid + 1
                else:
                    right = mid - 1

            return index
        
        start = findStart(nums, target)
        end = findEnd(nums, target)
        
        return [start, end]