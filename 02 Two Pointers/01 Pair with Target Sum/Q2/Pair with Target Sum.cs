public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i=0;
        int j=numbers.Length-1;
        int sum = numbers[i]+numbers[j];
        while(sum!=target) {
            if(sum<target) {
                i++;
            }
            else {
                j--;
            }
            sum = numbers[i]+numbers[j];
        }
        return new int[]{i+1,j+1};
    }
}