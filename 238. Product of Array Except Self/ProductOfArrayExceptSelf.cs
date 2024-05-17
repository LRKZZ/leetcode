public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        int[] answer = new int[length];

        answer[0] = 1;
        for(int i = 1; i < length; i++) {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        int R = 1;
        for(int i = length - 1; i >= 0; i--) {
            answer[i] = answer[i] * R;
            R = R * nums[i];
        }
        
        return answer;
    }
}