public class Solution {
    public string ReorganizeString(string s) {
		var Map = new Dictionary<char, int>();
		foreach(char c in s) {
			if(!Map.ContainsKey(c))
				Map.Add(c, 0);
			Map[c]++;
		}
		var pq = new PriorityQueue<char, int>(new FreqComparer());
		foreach (var key in Map.Keys) {
			pq.Enqueue(key, Map[key]);
		}

		StringBuilder sb = new StringBuilder();
		while (pq.Count > 1) {
			char CurrentChar = pq.Dequeue();
			var NextChar = pq.Dequeue();
			sb.Append(CurrentChar);
			sb.Append(NextChar);
			Map[CurrentChar]--;
			Map[NextChar]--;

			if (Map[CurrentChar] > 0) pq.Enqueue(CurrentChar, Map[CurrentChar]);
			if (Map[NextChar] > 0) pq.Enqueue(NextChar, Map[NextChar]);
		}
		if(pq.Count > 0) {
			char LastChar = pq.Dequeue();
			if (Map[LastChar] > 1) 
				return String.Empty;
			sb.Append(LastChar);
		}
		return sb.ToString();
    }
    public class FreqComparer : IComparer<int> {
        public int Compare(int x, int y) {
            return y - x;
        }
    }
}