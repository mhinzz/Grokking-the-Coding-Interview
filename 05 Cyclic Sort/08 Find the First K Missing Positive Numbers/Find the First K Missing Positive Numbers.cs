public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int count = 0;
        int num = 1;
        for (int i = 0; count < k; num++) {
            if (i >= arr.Length) {
                return num + (k - count - 1);
            }
            if (arr[i] != num) {
                count++;
            } else {
                i++;
            }
        }
        return num - 1;
    }
}