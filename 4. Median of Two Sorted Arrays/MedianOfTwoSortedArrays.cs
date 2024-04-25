public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combinedList = nums1.Concat(nums2).ToArray();
        combinedList = combinedList.OrderBy(x => x).ToArray();
        
        if (combinedList.Length % 2 == 0) {
            int i = combinedList.Length / 2;
            return (combinedList[i-1] + combinedList[i]) / 2.0;
        } else {
            int i = combinedList.Length / 2;
            return combinedList[i];
        }
    }
}