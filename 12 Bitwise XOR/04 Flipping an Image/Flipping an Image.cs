public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {        
        for(int i = 0; i < A.Length; i++){
            int left = 0, right = A[i].Length - 1;
            while(left < right){
                int temp = 1 - A[i][left];
                A[i][left] = 1 - A[i][right];
                A[i][right] = temp;
                left++;
                right--;
            }
            if(left == right){
                A[i][left] = 1 - A[i][left];
            }
        }
        return A;
    }
}