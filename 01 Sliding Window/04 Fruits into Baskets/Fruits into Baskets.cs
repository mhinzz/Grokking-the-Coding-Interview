public class Solution {
    public int TotalFruit(int[] fruits)     {
        Dictionary<int,int>cnt=new Dictionary<int,int>();     
        HashSet<int> st=new HashSet<int>();     
        int j=0;    
        int ans = 0;
        
        for (int i = 0; i < fruits.Length ; i ++) {
            if(!cnt.ContainsKey(fruits[i])) {
                cnt.Add(fruits[i],1);
            }
            else {
                cnt[fruits[i]] ++;
            }

            if (cnt[fruits[i]] == 1) {
                st.Add(fruits[i]);
                while (st.Count > 2) {
                    cnt[fruits[j]] --;
                    if (cnt[fruits[j]] == 0) {
                        st.Remove(fruits[j]);
                    }
                    j ++;
                }
            }
            ans = Math.Max(ans, i - j + 1);
        }
        return ans; 
    }
}