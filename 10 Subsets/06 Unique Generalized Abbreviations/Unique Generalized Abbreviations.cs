public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        List<char> parentheses = new List<char>(n*2);
        GenerateParenthesis(parentheses, n, 0, result);
        return result;
    }
    
    private void GenerateParenthesis(List<char> parentheses, int toOpen, int toClose, List<string> result) {
        if (toOpen == 0 && toClose == 0) {
            result.Add(new string(parentheses.ToArray()));
            return;
        }
        if (toOpen > 0) {
            parentheses.Add('(');
            GenerateParenthesis(parentheses, toOpen-1, toClose+1, result);
            parentheses.RemoveAt(parentheses.Count-1);
        }
        if (toClose > 0) {
            parentheses.Add(')');
            GenerateParenthesis(parentheses, toOpen, toClose-1, result);
            parentheses.RemoveAt(parentheses.Count-1);
        }
    }
}