public class Solution {
	public int[] FindRightInterval(int[][] intervals) {
		int n = intervals.Length;

		List<int> tmp = new List<int>();
		for (int i = 0; i < n; i++) tmp.Add(i);
		tmp.Sort((a, b) => intervals[a][0] - intervals[b][0]);

		int[] ret = new int[n];

		for (int i = 0; i < n; i++) {
			int t = tmp[i];
			int target = intervals[t][1];
			int left = i;
			int right = n - 1;
			while (left <= right) {
				int mid = (left + right) / 2;
				if (intervals[tmp[mid]][0] < target)
					left = mid + 1;
				else
					right = mid - 1;
			}
			ret[t] = left == n ? -1 : tmp[left];
		}
		return ret;
	}
}