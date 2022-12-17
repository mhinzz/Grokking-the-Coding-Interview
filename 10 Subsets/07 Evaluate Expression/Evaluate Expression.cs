public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        List<int> res = new List<int>();
        for (int i = 0; i < expression.Count(); i++) {
            char c = expression[i];
            if (c == '-' || c == '+' || c == '*') {
                String a = expression.Substring(0, i);
                String b = expression.Substring(i + 1);
                IList<int> al = DiffWaysToCompute(a);
                IList<int> bl = DiffWaysToCompute(b);
                foreach (int x in al) {
                    foreach (int y in bl) {
                        if (c == '-') {
                            res.Add(x - y);
                        } else if (c == '+') {
                            res.Add(x + y);
                        } else if (c == '*') {
                            res.Add(x * y);
                        }
                    }
                }
            }
        }
        if (res.Count() == 0) res.Add(int.Parse(expression));
        return res;
    }
}