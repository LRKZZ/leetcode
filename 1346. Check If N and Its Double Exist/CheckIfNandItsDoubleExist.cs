public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach(var num in arr) {
            if(seenNumbers.Contains(2 * num) || (num % 2 == 0 && seenNumbers.Contains(num / 2))) {
                return true;
            }
            seenNumbers.Add(num);
        }

        return false;
    }
}