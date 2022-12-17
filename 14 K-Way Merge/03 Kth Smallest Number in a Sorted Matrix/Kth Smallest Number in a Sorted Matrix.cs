public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        int n = matrix.Length;
        var indexes = new int[n];
        int currentMinIdx = 0;
        for (int i = 0; i < k; ++i) {
            while (indexes[currentMinIdx] == n) {
                currentMinIdx = (currentMinIdx + 1) % n;
            }

            for (int j = 0; j < n; ++j) {
                if (indexes[j] == n) continue;
                if (matrix[j][indexes[j]] <= matrix[currentMinIdx][indexes[currentMinIdx]]) {
                    currentMinIdx = j;
                }
            }
            indexes[currentMinIdx]++;
        }

        return matrix[currentMinIdx][indexes[currentMinIdx] - 1];   
    }
}