public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int index = 0;
        while (index < A.Length-1) {
            if (A[index] > A[index+1]) {
                return index;
            }
            index++;
        }
        return index;
    }
}