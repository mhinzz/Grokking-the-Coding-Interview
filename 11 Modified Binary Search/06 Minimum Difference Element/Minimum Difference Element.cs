public class Solution {
	public IList<int> FindClosestElements(int[] arr, int k, int x) {
		int left = 0;
		int right = arr.Length - 1;
		while (left <= right) {
			int mid = (left + right) / 2;
			if (arr[mid] > x)
				right = mid - 1;
			else 
				left = mid + 1;
		}

		List<int> ret = new List<int>();
		int count = 0;
		while (count < k && count < arr.Length) {
			if (left < arr.Length && right >= 0) {
				if (arr[left] - x < x - arr[right])
					ret.Add(arr[left++]);
				else 
					ret.Add(arr[right--]);
			} 
			else if (left < arr.Length)
				ret.Add(arr[left++]);
			else
				ret.Add(arr[right--]);

			count++;
		}
		ret.Sort();
		return ret;
	}
}