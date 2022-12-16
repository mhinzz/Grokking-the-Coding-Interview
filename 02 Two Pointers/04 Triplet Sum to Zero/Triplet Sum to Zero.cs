public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> answer = new List<IList<int>>();
        int n = nums.Length;
        for (int x = 0; x < n - 2; x++) {
            int target = -nums[x];
            int front = x + 1;
            int back = nums.Length - 1;

            if (target < 0) {
                break;
            }
            while (front < back) {
                if (nums[front] > target) {
                    break;
                }
                int sum = nums[front] + nums[back];
                if (target < sum) {
                    back--;
                }
                else if (target > sum) {
                    front++;
                }
                else {
                    answer.Add(new int[3] { -target, nums[front], nums[back] });
                    while (front < back && nums[front] == nums[++front]) ;
                    while (front < back && nums[back] == nums[--back]) ;
                }

            }
            while (x + 1 < n && nums[x] == nums[x + 1]) {
                x++;
            }
        }
        return answer;
    }
}