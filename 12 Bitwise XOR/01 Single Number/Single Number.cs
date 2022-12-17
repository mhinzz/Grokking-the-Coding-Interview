public class Solution {
    public int SingleNumber(int[] nums) => nums.Aggregate((a1, a2) => a1 ^ a2);
}