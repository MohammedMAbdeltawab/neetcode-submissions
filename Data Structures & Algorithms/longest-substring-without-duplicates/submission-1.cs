public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l=0,r=0,res=0;
        HashSet<char> st = new HashSet<char>();
        while(r<s.Length){
            while(st.Contains(s[r])){
                st.Remove(s[l++]);
            }
            st.Add(s[r]);
            res=Math.Max(res,r-l+1);
            r++;
        }
        return res;
    }
}
