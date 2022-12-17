public class Solution {
    public int MinimumDifference(int[] nums) {
        int L = nums.Length;
        var temp1 = new int[L/2];
        var temp2 = new int[L - L/2];
        Array.Copy(nums, 0, temp1, 0,  L / 2);
        Array.Copy(nums, L/2, temp2, 0, L-L/2);
        int[][] diff1 = Generate(temp1);
        int[][] diff2 = Generate(temp2);

        int min = Int32.MaxValue;
        for (int len = 0; len <= L / 2; len++) {
            int[] left = diff1[len];
            int[] right = diff2[len];

            int l = 0;
            int r = 0;

            while(l < left.Length && r < left.Length) {
                int diff = left[l] - right[r];
                min = Math.Min(min, Math.Abs(diff));
                if (diff < 0) {
                    l++;
                }
                else if (diff > 0) {
                    r++;
                } 
                else {
                    return 0;
                } 
            }
        }
        return min;
    }

    private int[][] Generate(int[] arr) {
        int n = arr.Length;
        int[][] ans = new int[n + 1][]; 
        int combo = 1;
        ans[0] = new int[combo];
        for (int i = 1; i <= n; i++) {
            combo = combo * (n - i + 1) / i;
            ans[i] = new int[combo];
        }
        int total = 0;
        foreach (int i in arr) {
            total += i;
        } 
        int limit = 1 << n;
        int[] counter = new int[n + 1];
        for (int i = 0; i < limit; i++) {
            int subSum = 0;
            for (int j = 0; j < n; j++) {
                if ((i >> j & 1) == 1) subSum += arr[j];
            }
            int rest = total - subSum;
            int lenOfSub = BitCount(i);
            ans[lenOfSub][counter[lenOfSub]++] = subSum - rest;
        }

        foreach (int[] a in ans) {
            Array.Sort(a);

        }

        return ans;
    }
    public static int BitCount(int n) {
        var count = 0;
        while (n != 0) {
            count++;
            n &= (n - 1);
        }
        return count;
    }
}