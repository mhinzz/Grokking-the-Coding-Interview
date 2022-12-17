public class Solution {
    public bool CanFinish(int num, int[][] pre) {
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        foreach (int[] edge in pre) {
            if (!adj.ContainsKey(edge[0]))
                adj[edge[0]] = new List<int>();
            adj[edge[0]].Add(edge[1]);
        }
        int[] colors = new int[num];
        foreach (int v in adj.Keys) {
            if (!DFS(v, adj, colors))
                return false;
        }
        return true;
    }
    
    private bool DFS(int v, Dictionary<int, List<int>> adj, int[] colors) {
        if (colors[v] == 2)
            return true;
        if (colors[v] == 1)
            return false;
        
        colors[v] = 1;
        bool result = true;
        if (adj.ContainsKey(v)) {
            foreach (int av in adj[v])
                result = result && DFS(av, adj, colors);           
        }
        colors[v] = 2;
        return result;
    }
}