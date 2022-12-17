public class FreqStack {
    private Dictionary<int,Stack<int>> freqStack = null;
    private Dictionary<int,int> freq = null;
    private int mfu = 0;
    
    public FreqStack() {
        freqStack = new Dictionary<int,Stack<int>>();
        freq = new Dictionary<int,int>();
    }
    
    public void Push(int val) {
        if(!freq.ContainsKey(val)) {
            freq.Add(val,1);
        }
        else {    
            freq[val]++;
        }
        mfu = Math.Max(mfu,freq[val]);
        if(!freqStack.ContainsKey(freq[val])) {
            freqStack.Add(freq[val],new Stack<int>());
        }
        freqStack[freq[val]].Push(val);
    }
    
    public int Pop() {
        int popped = freqStack[mfu].Pop();
        freq[popped]--;
        if(freqStack[mfu].Count == 0) {
            freqStack.Remove(mfu);
            mfu--;
        }
        return popped;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */