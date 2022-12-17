public class Solution {
    public int[] FindOrder(int num, int[][] pre) {
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        foreach (int[] edge in pre) {
            if (!adj.ContainsKey(edge[0]))
                adj[edge[0]] = new List<int>();
            adj[edge[0]].Add(edge[1]);
        }
        int[] colors = new int[num];
        List<int> result = new List<int>();
        for (int v = 0; v < num; v++) {
            if (!DFS(v, adj, colors, result))
                return new int[0];
        }
        return result.ToArray();
    }
    
    private bool DFS(int v, Dictionary<int, List<int>> adj, int[] colors, List<int> result) {
        if (colors[v] == 2)
            return true;
        if (colors[v] == 1)
            return false;
        
        colors[v] = 1;
        bool noCycles = true;
        if (adj.ContainsKey(v)) {
            foreach (int av in adj[v])
                noCycles = noCycles && DFS(av, adj, colors, result);           
        }
        colors[v] = 2;
        result.Add(v);
        return noCycles;
    }
}