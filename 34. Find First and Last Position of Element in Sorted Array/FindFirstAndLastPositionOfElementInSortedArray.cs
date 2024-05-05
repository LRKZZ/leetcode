public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int findStart(int[] nums, int target) {
            int index = -1;
            int left = 0, right = nums.Length - 1;
            
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    index = mid;
                    right = mid - 1;
                } else if (nums[mid] < target) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
            
            return index;
        }

        int findEnd(int[] nums, int target) {
            int index = -1;
            int left = 0, right = nums.Length - 1;
            
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    index = mid;
                    left = mid + 1; // Move right
                } else if (nums[mid] < target) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
            
            return index;
        }
        
        int start = findStart(nums, target);
        int end = findEnd(nums, target);
        
        return new int[] { start, end };
    }
}