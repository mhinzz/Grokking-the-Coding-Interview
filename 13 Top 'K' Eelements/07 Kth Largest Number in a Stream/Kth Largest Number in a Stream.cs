class KthLargest {
    private static int RANGE = 10000;
    private int[] freq = new int[2 * RANGE + 1];
    private bool firstQuery = true;
    private int pos;
    private int k;

    public KthLargest(int k, int[] nums) {
        foreach(int num in nums) {
            freq[num + RANGE]++;
        }
        this.k = k;
    }
    
    public int Add(int val) {
        val += RANGE;
        if(firstQuery) {
            firstQuery = false;
            freq[val]++;
            for(pos = freq.Length - 1; k > freq[pos]; pos--) {
                k -= freq[pos];
            }
            freq[pos] = k;
        } else {
            if(val > pos) {
                freq[val]++;
                freq[pos]--;
                while(freq[pos] == 0) {
                    pos++;
                }
            }
        }
        return pos - RANGE;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */